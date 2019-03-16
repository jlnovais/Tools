/*
 * IBAN4Net
 * Copyright 2015 Vaclav Beca [sinkien]
 *
 * Based on Artur Mkrtchyan's project IBAN4j (https://github.com/arturmkrtchyan/iban4j).
 *
 *
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IBAN4Net.Tests
{
    [TestClass]
    public class IbanUtilsTest2
    {
        [TestMethod]
        public void FromSameBankAndBranch_validIbansSameBankAndBranch_ShouldReturnTrue()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "PT50001000004999022000169";
            string errorDescription;

            Assert.IsTrue(IbanUtils.FromSameBankAndBranch(iban1, iban2, out errorDescription));
        }

        //
        //
        [TestMethod]
        public void FromSameBankAndBranch_validIbansSameBankDifferentBranch_ShouldReturnFalse()
        {
            string iban1 = "PT50001000010000000012313";
            string iban2 = "PT50001000000000000012328";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBankAndBranch(iban1, iban2, out errorDescription));
        }

        public void FromSameBankAndBranch_validIbansOtherBank_ShouldReturnFalse()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "BE39103123456719";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBankAndBranch(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBankAndBranch_invalidIbans_ShouldReturnfalse()
        {
            string iban1 = "";
            string iban2 = "PT50001000004999022000169";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBankAndBranch(iban1, iban2, out errorDescription));
        }

        //-------------------------------

        [TestMethod]
        public void FromSameBank_validIbansSameBank_ShouldReturnTrue ()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "PT50001000004999022000169";
            string errorDescription;

            Assert.IsTrue( IbanUtils.FromSameBank(iban1, iban2, out errorDescription) );
        }

        [TestMethod]
        public void FromSameBank_validIbansSameBank_ShouldReturnTrue2()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "PT50001000005009751000128";
            string errorDescription;

            Assert.IsTrue(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBank_validIbansSameBank_ShouldReturnTrue3()
        {
            string iban1 = "ES2121003642162200113323";
            string iban2 = "ES2121005744850200020333";
            string errorDescription;

            Assert.IsTrue(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        //AT611904300234573201
        [TestMethod]
        public void FromSameBank_validIbansOtherBank_ShouldReturnFalse()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "PT50002300004521167555794";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBank_validIbansOtherBank_ShouldReturnFalse2()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "BE39103123456719";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBank_invalidIbans_ShouldReturnfalse()
        {
            string iban1 = "";
            string iban2 = "PT50001000004999022000169";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBank_invalidIbans_ShouldReturnfalse2()
        {
            string iban1 = "PT50001000004999022000169";
            string iban2 = "";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBank_invalidIbans_ShouldReturnfalse3()
        {
            string iban1 = "";
            string iban2 = "";
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }

        [TestMethod]
        public void FromSameBank_invalidIbans_ShouldReturnfalse4()
        {
            string iban1 = null;
            string iban2 = null;
            string errorDescription;

            Assert.IsFalse(IbanUtils.FromSameBank(iban1, iban2, out errorDescription));
        }
    }
}
