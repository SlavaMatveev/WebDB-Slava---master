using RESTAURANT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RESTAURANT.Models
{
    public class Order
    {
        [Display(Name = "Код заказа")]
        public long ID { get; set; }
        [Display(Name = "Время")]
        public DateTime Time { get; set; }
        [Display(Name = "Дата")]
        public DateTime Date { get; set; }
        [Display(Name = "Отметка о выполнении")]
        public string check {get;set;}
        [Display(Name = "Стоимость")]
        public int Cost { get; set; }
        [Display(Name = "ФИО заказчика")]
        public string FGS_employer { get; set; }
        [Display(Name = "Номер телефона")]
        public int Telefon { get; set; }
        [Display(Name = "Код блюда 1")]
        public long? ID_dish_1 { get; set; }
        public DbSet<Menu> dish_1 { get; set; }
        [Display(Name = "Код блюда 2")]
        public long? ID_dish_2 { get; set; }
        public  DbSet<Menu> dish_2 { get; set; }
        [Display(Name = "Код блюда 3")]
        public long? ID_dish_3 { get; set; }
        public  DbSet<Menu> dish_3 { get; set; }
        [Display(Name = "Код сотрудника")]
        public long? IDemployees { get; set; }
        public DbSet<Menu> ID_employees { get; set; }
       

    }
}
