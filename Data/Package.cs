using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Package
    {
        //select PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission from Packages
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }

        public Package PackageClone()
        {
            Package pkg= new Package();
            pkg.PackageId = PackageId;
            pkg.PkgName = this.PkgName;
            pkg.PkgStartDate = this.PkgStartDate;
            pkg.PkgEndDate = this.PkgEndDate;
            pkg.PkgDesc = this.PkgDesc;
            pkg.PkgBasePrice = this.PkgBasePrice;
            pkg.PkgAgencyCommission = this.PkgAgencyCommission;

            return pkg;
        }
    }
}
