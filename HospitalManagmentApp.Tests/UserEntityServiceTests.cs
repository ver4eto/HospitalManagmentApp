namespace HospitalManagmentApp.Tests
{
    using HospitalManagmentApp.Data;
    using HospitalManagmentApp.DataModels;
    using HospitalManagmentApp.Services.Data;
    using Microsoft.AspNetCore.Identity;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Threading.Tasks;

    [TestFixture]
    public class UserEntityServiceTests
    {
        private Mock<UserManager<ApplicationUser>> _userManagerMock;
        private Mock<HMDbContext> _dbContextMock;
        private UserEntityService _userEntityService;

        [SetUp]
        public void SetUp()
        {

            var userStoreMock = new Mock<IUserStore<ApplicationUser>>();
            _userManagerMock = new Mock<UserManager<ApplicationUser>>(
                userStoreMock.Object,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null);


            _dbContextMock = new Mock<HMDbContext>();


            _userEntityService = new UserEntityService(_userManagerMock.Object, _dbContextMock.Object);
        }

        [Test]
        public async Task CreateApplicationUserAsync_CreatesUserAndAddsRole_Success()
        {

            var email = "test@example.com";
            var password = "SecurePassword123!";
            var role = "Admin";

            var expectedUser = new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                Email = email,
                EmailConfirmed = true,
                UserType = role
            };

            _userManagerMock
                .Setup(um => um.CreateAsync(It.IsAny<ApplicationUser>(), password))
                .ReturnsAsync(IdentityResult.Success)
                .Callback<ApplicationUser, string>((user, pass) => user.Id = expectedUser.Id); // Match expected ID

            _userManagerMock
                .Setup(um => um.AddToRoleAsync(It.IsAny<ApplicationUser>(), role))
                .ReturnsAsync(IdentityResult.Success);


            var userId = await _userEntityService.CreateApplicationUserAsync(email, password, role);


            Assert.That(userId, Is.EqualTo(expectedUser.Id), "User ID should match.");
            _userManagerMock.Verify(um => um.CreateAsync(It.Is<ApplicationUser>(u => u.Email == email), password), Times.Once);
            _userManagerMock.Verify(um => um.AddToRoleAsync(It.Is<ApplicationUser>(u => u.Email == email), role), Times.Once);
        }


        [Test]
        public void CreateApplicationUserAsync_ThrowsException_WhenUserCreationFails()
        {
            // Arrange
            var email = "fail@example.com";
            var password = "weak"; // Weak password to force failure
            var role = "Admin";

            _userManagerMock
                .Setup(um => um.CreateAsync(It.IsAny<ApplicationUser>(), password))
                .ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Password too weak" }));

            // Act & Assert
            var exception = Assert.ThrowsAsync<Exception>(async () =>
                await _userEntityService.CreateApplicationUserAsync(email, password, role));

            Assert.That(exception!.Message, Does.Contain("Password too weak"));
            _userManagerMock.Verify(um => um.CreateAsync(It.Is<ApplicationUser>(u => u.Email == email), password), Times.Once);
            _userManagerMock.Verify(um => um.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()), Times.Never);
        }

        [Test]
        public async Task CreateApplicationUserAsync_DoesNotAddRole_WhenRoleIsEmpty()
        {
            // Arrange
            var email = "norole@example.com";
            var password = "SecurePassword123!";
            var role = string.Empty;

            _userManagerMock
                .Setup(um => um.CreateAsync(It.IsAny<ApplicationUser>(), password))
                .ReturnsAsync(IdentityResult.Success);

            // Act
            var userId = await _userEntityService.CreateApplicationUserAsync(email, password, role);

            // Assert
            _userManagerMock.Verify(um => um.CreateAsync(It.Is<ApplicationUser>(u => u.Email == email), password), Times.Once);
            _userManagerMock.Verify(um => um.AddToRoleAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>()), Times.Never);
        }
    }

}