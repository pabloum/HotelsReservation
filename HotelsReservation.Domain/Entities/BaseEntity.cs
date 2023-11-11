using System;
using System.ComponentModel.DataAnnotations;

namespace HotelsReservation.Domain.Entities
{
	public class BaseEntity<TId> where TId : struct
    {
        [Key]
        public TId Id { get; set; }
    }
}

