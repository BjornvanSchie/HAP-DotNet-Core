using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HAP_DotNet_Core.Utils
{
    static class UUIDHelper
    {
        private static Regex validUUIDRegex = new Regex(@"^[0-9a-f]{8}-[0-9a-f]{4}-[1-5][0-9a-f]{3}-[89ab][0-9a-f]{3}-[0-9a-f]{12}$");

        public static bool IsValid(string UUID)
        {
            return validUUIDRegex.IsMatch(UUID);
        }
    }
}
