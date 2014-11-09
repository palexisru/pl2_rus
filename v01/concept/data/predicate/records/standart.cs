using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace pl2.data.predicate.records
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
            add_phase();
        }

        /// <summary>
        /// добавление фаз
        /// </summary>
        private void add_phase()
        {
            records.PhaseRow pr = r.Phase.NewPhaseRow();
            pr.phase_name = "Prepare";
            pr.PDCA = "Act";
            pr.Table.Rows.Add(pr);
            pr = r.Phase.NewPhaseRow();
            pr.phase_name = "Progress";
            pr.PDCA = "Plan";
            pr.Table.Rows.Add( pr );
            pr = r.Phase.NewPhaseRow();
            pr.phase_name = "Restriction";
            pr.PDCA = "Do";
            pr.Table.Rows.Add( pr );
            pr = r.Phase.NewPhaseRow();
            pr.phase_name = "Preservation";
            pr.PDCA = "Check";
            pr.Table.Rows.Add( pr );
        }

        /// <summary>
        /// добавление уровней абстрактности
        /// </summary>
        private void add_abstractions()
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

    }
}
