using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectRon.Data
{
	[Table("QRCode")]
	public class QRCode
	{
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated { get; set; }

		public string? Code { get; set; }
	}
}

