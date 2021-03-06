﻿using System.Collections.Generic;
using SIM.Sitecore9Installer.Tasks;

namespace SIM.Sitecore9Installer.Validation
{
  public interface IValidator
  {
    IEnumerable<ValidationResult> Evaluate(IEnumerable<Task> tasks);
    Dictionary<string, string> Data { get; set; }
  }
}
