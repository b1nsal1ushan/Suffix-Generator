public static string GetNewSuffix(string lastSuffix)
        {
            if (lastSuffix.IsNull())
                return "A";
            else
            {
                var suffixChar = lastSuffix.Left(1);
                var numbers_str = lastSuffix.Substring(1);
                var suffixNumber = 0;
                if (!numbers_str.IsNull())
                {
                    if (!int.TryParse(numbers_str, out suffixNumber))
                        throw new InvalidOperationException($"Given Suffix is '{lastSuffix}', while the Numbers part of this suffix is not a number");
                }
                if (suffixChar.IsEqual("Z"))
                {
                    suffixNumber++;
                    suffixChar = "A";
                }
                else
                {
                    suffixChar = char.ConvertFromUtf32(char.ConvertToUtf32(suffixChar, 0) + 1);
                }
                numbers_str = suffixNumber > 0 ? suffixNumber.ToString() : "";
                return $"{suffixChar}{numbers_str}";
            }
        }
