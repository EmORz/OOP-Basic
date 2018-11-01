using MilitaryElite.Contracts;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<Private> privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) :
            base(id, firstName, lastName, salary)
        {
            this.privates = new List<Private>();
        }
        public IReadOnlyCollection<IPrivate> Privates
        {
            get
            {
                return this.privates;
            }
        }
        public void AddPrivate(Private newPrivate)
        {
            this.privates.Add(newPrivate);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var item in privates)
            {
                sb.AppendLine("  "+item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
