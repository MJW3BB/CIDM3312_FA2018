using Microsoft.EntityFrameworkCore;
using System.Linq;
using Database;
using Libray.Length;
using Library.Mass;
using Libary.Temperature;

namespace WebAppConverter.Models
{
    public interface IDatabase
    {
        IQueryable<ITempConvert> TempConversions { get; }
        IQueryable<IMassConvert> MassConversions { get; }
        IQueryable<ILengthConvert> LengthConversions { get; }
    }
}