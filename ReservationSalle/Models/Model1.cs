namespace ReservationSalle.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }

  

         public virtual DbSet<Salle> Salles { get; set; }
         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Reservation> Reservations { get; set; }
         public virtual DbSet<Remarque> Remarques { get; set; }
    }


    // *********************SALLE*****
    public class Salle
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Type TypeSalle { get; set; }
        public bool Libre { get; set; }
    }   
    

    public enum Type
    {
        PetiteSalle,
        GrandeSalle,
        SalleMoyen,
    }

    // *********************USER*****
    public class User
    {
        public User()
        {
        }

        public User(string name, string prenom, string login, string password)
        {
            Name = name;
            Prenom = prenom;
            Login = login;
            Password = password;
            CategorieUser = Categorie.User;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Categorie CategorieUser { get; set; }

    }
    public enum Categorie
    {
        Admin,
        User,
        Bloque
    }

    // *********************Reservation*****
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime HeureDebut { get; set; }
        public DateTime HeureFin { get; set; }

    }

    // *********************Remarque*****

    public class Remarque
    {
        [Key]
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Reclamation { get; set; }

    }
}