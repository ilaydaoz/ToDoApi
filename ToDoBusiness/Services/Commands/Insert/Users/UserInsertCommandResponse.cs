namespace ToDoListBusiness.Services.Commands.Insert.Users
{
    public class UserInsertCommandResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
