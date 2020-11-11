using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTableApi.Models
{
    public class Product // product model class which is bought and added into expenses
    {
        // this is primary key
        [Key]// data annotations
        public int Id { get; set; }
        // prduct name
        public string Name { get; set; }
        // quantity bought
        public int Quantity { get; set; }
        // price each
        public double  Price { get; set; }
    }
}
