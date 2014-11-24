using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pl2.concept.data.predicate.records
{
    /// <summary>
    /// стандартные записи для описания периодической иерархии
    /// </summary>
    class standart
    {
        /// <summary>
        /// создание классификатора предикатов по умолчанию
        /// </summary>
        class Standart
        {
            private records r;
            public Standart()
            {
                r = new records();
                add_period();
            }

            /// <summary>
            /// добавление периодов развития
            /// </summary>
            private void add_period()
            {
                records.PeriodRow pr = r.Period.NewPeriodRow();
                pr.period_name = "Prepare";
                // pr.PDCA = "Act";
                pr.Table.Rows.Add( pr );
                pr = r.Period.NewPeriodRow();
                pr.period_name = "Elaboration";
                // pr.PDCA = "Plan";
                pr.Table.Rows.Add( pr );
                pr = r.Period.NewPeriodRow();
                pr.period_name = "Stabilisation";
                // pr.PDCA = "Do";
                pr.Table.Rows.Add( pr );
                pr = r.Period.NewPeriodRow();
                pr.period_name = "Conservation";
                // pr.PDCA = "Check";
                pr.Table.Rows.Add( pr );
            }

            /// <summary>
            /// добавление фаз познания
            /// </summary>
            private void add_phases()
            {
            }

            /// <summary>
            /// добавление видов сложности
            /// </summary>
            private void add_complexity()
            {

            }

            /// <summary>
            /// добавление уровней  идеальности
            /// </summary>
            private void add_ideality()
            {
            }

            /// <summary>
            /// добавление уровней абстрактности
            /// </summary>
            private void add_abstractions()
            {
            }

        }
    }
}
