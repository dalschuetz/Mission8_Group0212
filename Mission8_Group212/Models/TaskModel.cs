using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mission8_Group212.Models;

public class TaskModel
{
    [Key]
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public string DueDate { get; set; }
    public int Completed {get; set;}
   
    //Foreign key to Quadrant table returns a quad
    [ForeignKey("QuadId")] 
    public int QuadId { get; set; }
    
    
    //foreign key to Category Table. returns a cat
    [ForeignKey("CategoryId")] 
    public int CategoryId { get; set; }
    
    
    
}