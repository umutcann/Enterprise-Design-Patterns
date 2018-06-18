using CF.Data.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace APP.Data.Entity
{
    [Table("Device")]
    public class Device : IEntity
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
    }
}
