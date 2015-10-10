using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals.Converter.FromArabic;

namespace ToRoman.Test
{
    [TestClass]
    public class ConverterTest
    {
        private ToRomanConverter converter;

        [TestInitialize]
        public void Setup()
        {
            this.converter = new ToRomanConverter();
        }

        [TestMethod]
        public void Convertir_1_en_numeros_romanos()
        {
            string expected = "I";

            string resul = this.converter.ToRoman(1);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_3_en_numeros_romanos()
        {
            string expected = "III";

            string resul = this.converter.ToRoman(3);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_4_en_numeros_romanos()
        {
            string expected = "IV";

            string resul = this.converter.ToRoman(4);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_5_en_numeros_romanos()
        {
            string expected = "V";

            string resul = this.converter.ToRoman(5);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_6_en_numeros_romanos()
        {
            string expected = "VI";

            string resul = this.converter.ToRoman(6);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_7_en_numeros_romanos()
        {
            string expected = "VII";

            string resul = this.converter.ToRoman(7);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_8_en_numeros_romanos()
        {
            string expected = "VIII";

            string resul = this.converter.ToRoman(8);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_9_en_numeros_romanos()
        {
            string expected = "IX";

            string resul = this.converter.ToRoman(9);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_10_en_numeros_romanos()
        {
            string expected = "X";

            string resul = this.converter.ToRoman(10);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_15_en_numeros_romanos()
        {
            string expected = "XV";

            string resul = this.converter.ToRoman(15);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_19_en_numeros_romanos()
        {
            string expected = "XIX";

            string resul = this.converter.ToRoman(19);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_24_en_numeros_romanos()
        {
            string expected = "XXIV";

            string resul = this.converter.ToRoman(24);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_118_en_numeros_romanos()
        {
            string expected = "CXVIII";

            string resul = this.converter.ToRoman(118);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_579_en_numeros_romanos()
        {
            string expected = "DLXXIX";

            string resul = this.converter.ToRoman(579);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_1999_en_numeros_romanos()
        {
            string expected = "MCMXCIX";

            string resul = this.converter.ToRoman(1999);

            Assert.AreEqual(expected, resul);
        }

        [TestMethod]
        public void Convertir_3999_en_numeros_romanos()
        {
            string expected = "MMMCMXCIX";

            string resul = this.converter.ToRoman(3999);

            Assert.AreEqual(expected, resul);
        }
    }
}
