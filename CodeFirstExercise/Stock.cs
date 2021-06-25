using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirstExcercise
{
    class Stock
    {

        [Key] // - This sets your primary in your table 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // - Turns on Identity at (1,1) 
        [Required] //- This property may NOT be null, MUST have a value
        public int Id { get; set; }

        [MaxLength(20)]
        public string Symbol { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }


        [Range(0, 5000)]
        public int Price { get; set; }




    }
}
