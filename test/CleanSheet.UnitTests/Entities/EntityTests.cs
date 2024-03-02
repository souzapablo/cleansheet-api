namespace CleanSheet.UnitTests.Entities;
public class EntityTests
{
    [Fact]
    [DisplayName("Entity should change IsDeleted to true when Delete")]
    public void Entity_Should_ChangeIsDeletedToTrue_When_Delete()
    {
        // Arrange
        var manager = new Career(Guid.NewGuid(), "Testing");
        var isDeleted = manager.IsDeleted;

        // Act
        manager.Delete();

        // Assert
        manager.IsDeleted.Should().BeTrue();    
        manager.IsDeleted.Should().NotBe(isDeleted);
    }
}
