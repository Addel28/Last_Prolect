//namespace Last_Prolect.Model
//{
//    public class Class
//    {
//    }
//}
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Добавьте это свойство, чтобы указать на сообщения, принадлежащие пользователю
    public ICollection<Message> Messages { get; set; }
}

public class Message
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }

    public User User { get; set; }
}