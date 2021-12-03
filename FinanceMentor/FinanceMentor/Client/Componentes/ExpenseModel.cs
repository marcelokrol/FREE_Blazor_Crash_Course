﻿using System;
using System.ComponentModel.DataAnnotations;
using FinanceMentor.Shared;

namespace FinanceMentor.Client.Componentes
{
   public class ExpenseModel
   {
      [Required]
      public DateTime Date { get; set; }

      [Required]
      [StringLength(50)]
      public string Subject { get; set; }

      [Required]
      public ExpenseCategory Category { get; set; }

      [Required]
      public decimal Amount { get; set; }
   }
}