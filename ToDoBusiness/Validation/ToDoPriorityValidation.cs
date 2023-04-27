using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoBusiness.Services.Commands.Insert.ToDoLists;

namespace ToDoBusiness.Validation
{
    public class ToDoPriorityValidation : AbstractValidator<ToDoListInsertCommandRequestModel>
    {
        public ToDoPriorityValidation()
        {
            RuleFor(x => x.Priority)
               .NotEmpty().WithMessage("Öncelik alanı boş bırakılamaz.")
               .Must(x => x == "az önemli" || x == "orta önemli" || x == "çok önemli")
               .WithMessage("Geçersiz öncelik değeri. Öncelik 'az önemli', 'orta önemli' veya 'çok önemli' olmalıdır.");
        }
    }
}
