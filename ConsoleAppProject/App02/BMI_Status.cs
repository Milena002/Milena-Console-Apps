using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleAppProject.App02

{
    public enum BMI_Status
    {
        None,
        [Display(Name = "Underweight")]
         UnderWeight,
        [Display(Name = "Normal weight")]
        NormalWeight,
        [Display(Name = "Over weight")]
        OverWeight,
        [Display(Name = "Obese Class I")]
        ObeseI,
        [Display(Name = "Obese Class II")]
        ObeseII,
        [Display(Name = "Obese Class III")]
        ObeseIII
    }
}