using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_exe.Validator
{
    internal class Validation_classes
    {
        public interface IValidator
        {
            bool IsValid(string input);
        }

        public class LengthValidator : IValidator
        {
            public bool IsValid(string input)
                => input.Length > 3;
        }

        public class NotEmptyValidator : IValidator
        {
            public bool IsValid(string input)
                => !string.IsNullOrEmpty(input);
        }

        public class Run
        {
            public void RunValidation(List<IValidator> validators, string input)
            {
                foreach (var v in validators)
                {
                    bool ok = v.IsValid(input);
                    Console.WriteLine($"{v.GetType().Name}: " + (ok ? "OK" : "INVALID"));
                }
            }

        }
    }
}
