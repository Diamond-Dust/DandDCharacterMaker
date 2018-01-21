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

        public ClassesViewModel(ApplicationDbContext _dbContext)
        {
            int ClassId, ModifiersId;
            string Name;

            var classList = _dbContext.Classes.ToList();
            Classes = new ClassModel[classList.Count()];
            StatModifiers = new int[6];

            for (int i = 0; i < classList.Count(); i++)
            {
                ClassId = classList[i].ClassID;
                Name = classList
                    .Where(x => x.ClassID == ClassId)
                    .FirstOrDefault()
                    .Name;
                ModifiersId = classList.Where(x => x.ClassID == ClassId).FirstOrDefault().ModifiersID;

                Classes[i] = new Models.ClassModel(ClassId, Name, ModifiersId);
            }
        }
    }
}