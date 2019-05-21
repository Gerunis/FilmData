using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace FilmData.Web.Models
{
    public class FilmDataDbContext : DbContext
    {
        public DbSet<DbFilm> Films { get; set; }
        public DbSet<DbActor> Actors { get; set; }
        public static string ConnectionString { get; set; }

        public FilmDataDbContext()
        {
            Database.EnsureCreated();
        }

        public FilmDataDbContext(DbContextOptions<FilmDataDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }

    public class DbFilm
    {
        public DbFilm()
        {

        }

        public DbFilm(Film film)
        {
            Name = film.Name;
            Year = film.Year;
            Country = film.Countrie;
            Duration = film.Duration;
            AgeRating = film.AgeRating;
            Poster = film.Poster;
            Credits = new Collection<DbWork>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Год выпуск
        /// </summary>
        public DateTime Year { get; set; }
        /// <summary>
        /// Страны производства
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Продолжительность
        /// </summary>
        public DateTime Duration { get; set; }
        /// <summary>
        /// Возростной рейтинг
        /// </summary>
        public AgeRating AgeRating { get; set; }
        /// <summary>
        /// Актеры и съемочная команда
        /// </summary>
        public Collection<DbWork> Credits { get; set; }
        /// <summary>
        /// Постер
        /// </summary>
        public byte[] Poster { get; set; }
    }

    public class DbActor
    {
        public DbActor() { }
        public DbActor(Actor actor)
        {
            FirstName = actor.FirstName;
            LastName = actor.LastName;
            Dob = actor.Dob;
            Foto = actor.Foto;
            Works = new Collection<DbWork>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Dob { get; set; }
        /// <summary>
        /// Список работ
        /// </summary>
        public Collection<DbWork> Works { get; set; }
        /// <summary>
        /// Фото
        /// </summary>
        public byte[] Foto { get; set; }
    }

    public class DbWork
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Id фильма
        /// </summary>
        [ForeignKey("FilmId")]
        public virtual DbFilm Film { get; set; }
        /// <summary>
        /// Id актера
        /// </summary>
        [ForeignKey("ActorId")]
        public virtual DbActor Actor { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public Position Position { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Discription { get; set; }
    }

}