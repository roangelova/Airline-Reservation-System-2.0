using ARS.Common.Entities.Contracts;
using ARS.Common.TrackDataChanges;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARS.Common.Entities
{
    [Table("Adults")]
    public class Adult : Passenger
    {
    }
}
