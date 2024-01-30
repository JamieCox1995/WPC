using Classes.Models;
using System.Windows.Forms;

namespace WPCCrimeUnitTesting
{
    public class CrimeListValidationTest
    {
        [Theory]
        [InlineData("")]            // should fail. Empty String
        [InlineData("asdf")]        // Should fail, NaN
        [InlineData("100")]         // Should fail too large.
        [InlineData("62.15000")]         // Should fail too large UK.
        [InlineData("-91")]         // Should fail too small
        [InlineData("49.55555")]         // Should fail too small UK
        public void Test_LatitudeValidation_Failures(string _Value)
        {
            Assert.False(CrimeList.IsLatitudeValid(_Value, out string message));
        }

        [Theory]
        [InlineData("51.44237")]
        [InlineData("50.10319")]
        [InlineData("60.15456")]
        public void Test_LatitudeValidation_Successes(string _Value)
        {
            Assert.True(CrimeList.IsLatitudeValid(_Value, out string message));
        }

        [Theory]
        [InlineData("")]            // should fail. Empty String
        [InlineData("asdf")]        // Should fail, NaN
        [InlineData("183")]         // Should fail too large.
        [InlineData("1.85789")]         // Should fail too large UK
        [InlineData("-200")]         // Should fail too small
        [InlineData("8.64133")]         // Should fail too small UK
        public void Test_LongitudeValidation_Failures(string _Value)
        {
            Assert.False(CrimeList.IsLongitudeValid(_Value, out string message));
        }

        [Theory]
        [InlineData("-2.49810")]
        [InlineData("-7.64133")]
        [InlineData("1.75159")]
        public void Test_LongitudeValidation_Successes(string _Value)
        {
            Assert.True(CrimeList.IsLongitudeValid(_Value, out string message));
        }

        [Theory]
        [InlineData("")]
        [InlineData("asdg")]
        [InlineData("2025-01")]
        [InlineData("2023-13")]
        [InlineData("2022-12")]
        [InlineData("2024-01")]
        public void Test_DateValidation_Failures(string _Value)
        {
            Assert.False(CrimeList.IsDateValid(_Value, out string message));
        }

        [Theory]
        [InlineData("2023-12")]
        [InlineData("2023-02")]
        [InlineData("2023-07")]
        public void Test_DateValidation_Successes(string _Value)
        {
            Assert.True(CrimeList.IsDateValid(_Value, out string message));
        }
    }
}
