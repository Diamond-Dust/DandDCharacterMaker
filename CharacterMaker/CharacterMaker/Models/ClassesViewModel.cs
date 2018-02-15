using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharacterMaker.Models
{
    public class ClassesViewModel
    {
        public ClassModel[] Classes { get; private set; }
        public int[] StatModifiers { get; set; }
        public string PreferredClass { get; set; }
        public List<string>[] AdditionalInfo { get; set; }

        public ClassesViewModel(ApplicationDbContext _dbContext)
        {
            int ClassId, ModifiersId;
            string Name;

            var classList = _dbContext.Classes.ToList();
            Classes = new ClassModel[classList.Count()];
            StatModifiers = new int[6];
            AdditionalInfo = new List<string>[classList.Count()];

            for (int i = 0; i < classList.Count(); i++)
            {
                ClassId = classList[i].ClassID;
                Name = classList
                    .Where(x => x.ClassID == ClassId)
                    .FirstOrDefault()
                    .Name;
                ModifiersId = classList.Where(x => x.ClassID == ClassId).FirstOrDefault().ModifiersID;

                AdditionalInfo[i] = new List<string>();
                if (_dbContext.ClassImgs.Where(x => x.ClassID == ClassId).FirstOrDefault() != null)
                    AdditionalInfo[i].Add(_dbContext.ClassImgs.Where(x => x.ClassID == ClassId).FirstOrDefault().Address);
                var Traits = _dbContext.ClassTraits.Where(x => x.ClassID == ClassId);
                foreach (var trait in Traits)
                    AdditionalInfo[i].Add(trait.Trait);

                Classes[i] = new Models.ClassModel(ClassId, Name, ModifiersId);
            }
        }
    }
}