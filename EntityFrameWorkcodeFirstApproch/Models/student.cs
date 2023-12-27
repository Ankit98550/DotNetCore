using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkcodeFirstApproch.Models
{
    public class student
    {
        //first create class
        //second create model class
        // third create DbContext class

        //cmd
        //add-migration codeFirstCreateDB
        //update-database

        //key for that column i want to make primary key
        [Key]
        public  int id { get; set; }
        //column name i want  StudentName and typeName is data type
        [Column("StudentName",TypeName ="varchar(100)" )]
        public string name { get; set; }
        [Column("StudentGender",TypeName ="varchar(100)")]
        public string Gender { get; set; }
        public int age { get; set; }
    }
}
