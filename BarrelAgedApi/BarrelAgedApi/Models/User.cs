using System.ComponentModel.DataAnnotations;

namespace BarrelAgedApi.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        public string Salt { get; set; } = "";

        public string? Key { get; set; }
        public string? FingerPrint { get; set; }

        public User(){}

        public User(UserDto dto)
        {
            this.Id = 0;
            this.Name = dto.Name;
            this.Email = dto.Email;
            this.Password = dto.Password;
            this.Salt = "String";
        }

        public void encrypt()
        {
            EncryptionHandler handler = new EncryptionHandler();
            byte[] salt = handler.AddSalt();
            this.Salt = Convert.ToBase64String(salt);
            this.Password = handler.hash(this.Password, salt);
        }

        public void keepOldInfo(string salt, string pass)
        {
            this.Salt = salt;
            this.Password = pass;
        }
    }
}
