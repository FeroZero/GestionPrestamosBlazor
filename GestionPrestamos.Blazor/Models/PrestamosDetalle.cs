using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPrestamos.Models
{
	public class PrestamosDetalle
	{
		[Key]
		public int PrestamoDetalleId { get; set; }

		public string CuotaNo { get; set; }

		public DateTime Fecha { get; set; } = DateTime.Now;

		public double Valor { get; set; }

		public double Balance { get; set; }

		[ForeignKey("PrestamoId")]
		[InverseProperty("PrestamosDetalle")]
		public int PrestamoId { get; set; }
		public Prestamos Prestamos { get; set; }
	}
}
