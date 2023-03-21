using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRon.Data;

[Table("SelectedPrize")]
public class SelectedPrize
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public string? Name { get; set; }
    public string? User { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime Updated { get; set; }
}

