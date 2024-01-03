using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace proiect2.Models
{
  public  class RecipeList : Microsoft.Maui.Controls.Page
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }


        // Legătură către utilizatorul care a salvat rețeta

        public int? RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        [Display(Name = "Saved Date")]
        [DataType(DataType.Date)]
        public DateTime SavedDate { get; set; }


    }
}
