using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Mission8_Group212.Models;

public class Quadrant
{
    [Key]
    public int QuadId { get; set; }
    public string QuadType { get; set; }
    
}