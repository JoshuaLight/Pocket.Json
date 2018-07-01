﻿using System;
using Xunit;

namespace Pocket.Json.Tests.Unwrap
{
    public class JsonPrimitivesTest
    {
        [Fact]
        public void Byte()
        {
            for (var i = 0; i < 256; i++)
                Unwraps(i.ToString()).To((byte) i);
        }

        [Fact]
        public void Char()
        {
            Unwraps("a").To('a');
            Unwraps("b").To('b');
            Unwraps("c").To('c');
            Unwraps("d").To('d');
            Unwraps("e").To('e');
            Unwraps("0").To('0');
        }

        [Fact]
        public void Double()
        {
            Unwraps("0").To(0.0);
            Unwraps("0.1").To(0.1);
            Unwraps("0.01").To(0.01);
            Unwraps("0.001").To(0.001);
            Unwraps("0.0001").To(0.0001);
            Unwraps("0.00001").To(0.00001);
            Unwraps("0.000001").To(0.000001);
            Unwraps("0.0000001").To(0.0000001);
            Unwraps("0.00000001").To(0.00000001);
            Unwraps("0.000000001").To(0.000000001);
            Unwraps("0.0000000001").To(0.0000000001);
            Unwraps("0.00000000001").To(0.00000000001);
            Unwraps("0.000000000001").To(0.000000000001);
            Unwraps("0.0000000000001").To(0.0000000000001);
            Unwraps("0.00000000000001").To(0.00000000000001);
            Unwraps("0.000000000000001").To(0.0);
            Unwraps("0.0000000000000001").To(0.0);
            Unwraps("0.00000000000000001").To(0.0);
            Unwraps("0.000000000000000001").To(0.0);
            Unwraps("0.0000000000000000001").To(0.0);
            Unwraps("0.00000000000000000001").To(0.0);
            Unwraps("0.000000000000000000001").To(0.0);
            Unwraps("0.0000000000000000000001").To(0.0);

            Unwraps("1.1").To(1.1);
            Unwraps("1.12").To(1.12);
            Unwraps("1.123").To(1.123);
            Unwraps("1.1234").To(1.1234);
            Unwraps("1.12345").To(1.12345);
            Unwraps("1.123456").To(1.123456);
            Unwraps("1.1234567").To(1.1234567);
            Unwraps("1.12345678").To(1.12345678);
            Unwraps("1.123456789").To(1.123456789);
            Unwraps("1.1234567891").To(1.1234567891);
            Unwraps("1.12345678912").To(1.12345678912);
            Unwraps("1.123456789123").To(1.123456789123);
            Unwraps("1.1234567891234").To(1.1234567891234);
            Unwraps("1.12345678912345").To(1.12345678912345);
            Unwraps("1.123456789123456").To(1.12345678912345);
            Unwraps("1.1234567891234567").To(1.12345678912345);
            Unwraps("1.12345678912345678").To(1.12345678912345);
            Unwraps("1.123456789123456789").To(1.12345678912345);
            Unwraps("1.1234567891234567891").To(1.12345678912345);
            Unwraps("1.12345678912345678912").To(1.12345678912345);
            Unwraps("1.123456789123456789123").To(1.12345678912345);

            Unwraps("11.1").To(11.1);
            Unwraps("11.12").To(11.12);
            Unwraps("11.123").To(11.123);
            Unwraps("11.1234").To(11.1234);
            Unwraps("11.12345").To(11.12345);
            Unwraps("11.123456").To(11.123456);
            Unwraps("11.1234567").To(11.1234567);
            Unwraps("11.12345678").To(11.12345678);
            Unwraps("11.123456789").To(11.123456789);
            Unwraps("11.1234567891").To(11.1234567891);
            Unwraps("11.12345678912").To(11.12345678912);
            Unwraps("11.123456789123").To(11.123456789123);
            Unwraps("11.1234567891234").To(11.1234567891234);
            Unwraps("11.12345678912345").To(11.1234567891234);
            Unwraps("11.123456789123456").To(11.1234567891234);
            Unwraps("11.1234567891234567").To(11.1234567891234);
            Unwraps("11.12345678912345678").To(11.1234567891234);
            Unwraps("11.123456789123456789").To(11.1234567891234);
            Unwraps("11.1234567891234567891").To(11.1234567891234);
            Unwraps("11.12345678912345678912").To(11.1234567891234);
            Unwraps("11.123456789123456789123").To(11.1234567891234);

            Unwraps("111.1").To(111.1);
            Unwraps("111.12").To(111.12);
            Unwraps("111.123").To(111.123);
            Unwraps("111.1234").To(111.1234);
            Unwraps("111.12345").To(111.12345);
            Unwraps("111.123456").To(111.123456);
            Unwraps("111.1234567").To(111.1234567);
            Unwraps("111.12345678").To(111.12345678);
            Unwraps("111.123456789").To(111.123456789);
            Unwraps("111.1234567891").To(111.1234567891);
            Unwraps("111.12345678912").To(111.12345678912);
            Unwraps("111.123456789123").To(111.123456789123);
            Unwraps("111.1234567891234").To(111.123456789123);
            Unwraps("111.12345678912345").To(111.123456789123);
            Unwraps("111.123456789123456").To(111.123456789123);
            Unwraps("111.1234567891234567").To(111.123456789123);
            Unwraps("111.12345678912345678").To(111.123456789123);

            Unwraps("1111.1").To(1111.1);
            Unwraps("1111.12").To(1111.12);
            Unwraps("1111.123").To(1111.123);
            Unwraps("1111.1234").To(1111.1234);
            Unwraps("1111.12345").To(1111.12345);
            Unwraps("1111.123456").To(1111.123456);
            Unwraps("1111.1234567").To(1111.1234567);
            Unwraps("1111.12345678").To(1111.12345678);
            Unwraps("1111.123456789").To(1111.123456789);
            Unwraps("1111.1234567891").To(1111.1234567891);
            Unwraps("1111.12345678912").To(1111.12345678912);
            Unwraps("1111.123456789123").To(1111.12345678912);
            Unwraps("1111.1234567891234").To(1111.12345678912);
            Unwraps("1111.12345678912345").To(1111.12345678912);
            Unwraps("1111.123456789123456").To(1111.12345678912);
            Unwraps("1111.1234567891234567").To(1111.12345678912);

            Unwraps("11111.1").To(11111.1);
            Unwraps("11111.12").To(11111.12);
            Unwraps("11111.123").To(11111.123);
            Unwraps("11111.1234").To(11111.1234);
            Unwraps("11111.12345").To(11111.12345);
            Unwraps("11111.123456").To(11111.123456);
            Unwraps("11111.1234567").To(11111.1234567);
            Unwraps("11111.12345678").To(11111.12345678);
            Unwraps("11111.123456789").To(11111.123456789);
            Unwraps("11111.1234567891").To(11111.1234567891);
            Unwraps("11111.12345678912").To(11111.1234567891);
            Unwraps("11111.123456789123").To(11111.1234567891);
            Unwraps("11111.1234567891234").To(11111.1234567891);
            Unwraps("11111.12345678912345").To(11111.1234567891);
            Unwraps("11111.123456789123456").To(11111.1234567891);

            Unwraps("111111.1").To(111111.1);
            Unwraps("111111.12").To(111111.12);
            Unwraps("111111.123").To(111111.123);
            Unwraps("111111.1234").To(111111.1234);
            Unwraps("111111.12345").To(111111.12345);
            Unwraps("111111.123456").To(111111.123456);
            Unwraps("111111.1234567").To(111111.1234567);
            Unwraps("111111.12345678").To(111111.12345678);
            Unwraps("111111.123456789").To(111111.123456789);
            Unwraps("111111.1234567891").To(111111.123456789);
            Unwraps("111111.12345678912").To(111111.123456789);
            Unwraps("111111.123456789123").To(111111.123456789);
            Unwraps("111111.1234567891234").To(111111.123456789);
            Unwraps("111111.12345678912345").To(111111.123456789);

            Unwraps("1111111.1").To(1111111.1);
            Unwraps("1111111.12").To(1111111.12);
            Unwraps("1111111.123").To(1111111.123);
            Unwraps("1111111.1234").To(1111111.1234);
            Unwraps("1111111.12345").To(1111111.12345);
            Unwraps("1111111.123456").To(1111111.123456);
            Unwraps("1111111.1234567").To(1111111.1234567);
            Unwraps("1111111.12345678").To(1111111.12345678);
            Unwraps("1111111.123456789").To(1111111.12345678);
            Unwraps("1111111.1234567891").To(1111111.12345678);
            Unwraps("1111111.12345678912").To(1111111.12345678);
            Unwraps("1111111.123456789123").To(1111111.12345678);
            Unwraps("1111111.1234567891234").To(1111111.12345678);

            Unwraps("11111111.1").To(11111111.1);
            Unwraps("11111111.12").To(11111111.12);
            Unwraps("11111111.123").To(11111111.123);
            Unwraps("11111111.1234").To(11111111.1234);
            Unwraps("11111111.12345").To(11111111.12345);
            Unwraps("11111111.123456").To(11111111.123456);
            Unwraps("11111111.1234567").To(11111111.1234567);
            Unwraps("11111111.12345678").To(11111111.1234567);
            Unwraps("11111111.123456789").To(11111111.1234567);
            Unwraps("11111111.1234567891").To(11111111.1234567);
            Unwraps("11111111.12345678912").To(11111111.1234567);
            Unwraps("11111111.123456789123").To(11111111.1234567);

            Unwraps("111111111.1").To(111111111.1);
            Unwraps("111111111.12").To(111111111.12);
            Unwraps("111111111.123").To(111111111.123);
            Unwraps("111111111.1234").To(111111111.1234);
            Unwraps("111111111.12345").To(111111111.12345);
            Unwraps("111111111.123456").To(111111111.123456);
            Unwraps("111111111.1234567").To(111111111.123456);
            Unwraps("111111111.12345678").To(111111111.123456);
            Unwraps("111111111.123456789").To(111111111.123456);
            Unwraps("111111111.1234567891").To(111111111.123456);
            Unwraps("111111111.12345678912").To(111111111.123456);

            Unwraps("1111111111.1").To(1111111111.1);
            Unwraps("1111111111.12").To(1111111111.12);
            Unwraps("1111111111.123").To(1111111111.123);
            Unwraps("1111111111.1234").To(1111111111.1234);
            Unwraps("1111111111.12345").To(1111111111.12345);
            Unwraps("1111111111.123456").To(1111111111.12345);
            Unwraps("1111111111.1234567").To(1111111111.12345);
            Unwraps("1111111111.12345678").To(1111111111.12345);
            Unwraps("1111111111.123456789").To(1111111111.12345);
            Unwraps("1111111111.1234567891").To(1111111111.12345);

            Unwraps("11111111111.1").To(11111111111.1);
            Unwraps("11111111111.12").To(11111111111.12);
            Unwraps("11111111111.123").To(11111111111.123);
            Unwraps("11111111111.1234").To(11111111111.1234);
            Unwraps("11111111111.12345").To(11111111111.1234);
            Unwraps("11111111111.123456").To(11111111111.1234);
            Unwraps("11111111111.1234567").To(11111111111.1234);
            Unwraps("11111111111.12345678").To(11111111111.1234);
            Unwraps("11111111111.123456789").To(11111111111.1234);

            Unwraps("111111111111.1").To(111111111111.1);
            Unwraps("111111111111.12").To(111111111111.12);
            Unwraps("111111111111.123").To(111111111111.123);
            Unwraps("111111111111.1234").To(111111111111.123);
            Unwraps("111111111111.12345").To(111111111111.123);
            Unwraps("111111111111.123456").To(111111111111.123);
            Unwraps("111111111111.1234567").To(111111111111.123);
            Unwraps("111111111111.12345678").To(111111111111.123);

            Unwraps("1111111111111.1").To(1111111111111.1);
            Unwraps("1111111111111.12").To(1111111111111.12);
            Unwraps("1111111111111.123").To(1111111111111.12);
            Unwraps("1111111111111.1234").To(1111111111111.12);
            Unwraps("1111111111111.12345").To(1111111111111.12);
            Unwraps("1111111111111.123456").To(1111111111111.12);
            Unwraps("1111111111111.1234567").To(1111111111111.12);

            Unwraps("11111111111111.1").To(11111111111111.1);
            Unwraps("11111111111111.12").To(11111111111111.1);
            Unwraps("11111111111111.123").To(11111111111111.1);
            Unwraps("11111111111111.1234").To(11111111111111.1);
            Unwraps("11111111111111.12345").To(11111111111111.1);
            Unwraps("11111111111111.123456").To(11111111111111.1);

            Unwraps("111111111111111.1").To(111111111111111.0);
            Unwraps("111111111111111.12").To(111111111111111.0);
            Unwraps("111111111111111.123").To(111111111111111.0);
            Unwraps("111111111111111.1234").To(111111111111111.0);
            Unwraps("111111111111111.12345").To(111111111111111.0);

            Unwraps("111111111111111E1").To(1111111111111110.0);
            Unwraps("111111111111111E2").To(11111111111111100.0);
            Unwraps("111111111111111E3").To(111111111111111000.0);
            Unwraps("111111111111111E4").To(1111111111111110000.0);
            Unwraps("111111111111111E5").To(11111111111111100000.0);
            Unwraps("111111111111111E6").To(111111111111111000000.0);
            Unwraps("111111111111111E7").To(1111111111111110000000.0);
            Unwraps("111111111111111E8").To(11111111111111100000000.0);
            Unwraps("111111111111111E9").To(111111111111111000000000.0);
            Unwraps("111111111111111E10").To(1111111111111110000000000.0);
            Unwraps("111111111111111E11").To(11111111111111100000000000.0);
            Unwraps("111111111111111E12").To(111111111111111000000000000.0);
            Unwraps("111111111111111E13").To(1111111111111110000000000000.0);
            Unwraps("111111111111111E14").To(11111111111111100000000000000.0);
            Unwraps("111111111111111E15").To(111111111111111000000000000000.0);
            Unwraps("111111111111111E16").To(1111111111111110000000000000000.0);
            Unwraps("111111111111111E17").To(11111111111111100000000000000000.0);
            Unwraps("111111111111111E18").To(111111111111111000000000000000000.0);
            Unwraps("111111111111111E19").To(1111111111111110000000000000000000.0);
            Unwraps("111111111111111E20").To(11111111111111100000000000000000000.0);
            Unwraps("111111111111111E21").To(111111111111111000000000000000000000.0);

            Unwraps("0").To(0.0);
            Unwraps("0.1").To(0.1);
            Unwraps("0.02").To(0.02);
            Unwraps("0.102").To(0.102);
            Unwraps("0.1002").To(0.1002);
            Unwraps("0.10203").To(0.10203);
            Unwraps("0.102034").To(0.102034);
            Unwraps("0.1020341").To(0.1020341);
            Unwraps("0.10203411").To(0.10203411);
            Unwraps("0.102034111").To(0.102034111);
            Unwraps("0.1020341101").To(0.1020341101);
            Unwraps("0.10203411001").To(0.10203411001);
            Unwraps("0.102034110001").To(0.102034110001);
            Unwraps("0.1020341100001").To(0.1020341100001);
            Unwraps("0.10203411000001").To(0.10203411000001);
            Unwraps("0.102034110000001").To(0.10203411);
            Unwraps("0.1020341100000001").To(0.10203411);
            Unwraps("0.10203411000000001").To(0.10203411);

            Unwraps("0.523154234575693").To(0.52315423457569);
        }

        [Fact]
        public void Float()
        {
            Unwraps("0").To(0f);
            Unwraps("0.0").To(0f);
            Unwraps("0.1").To(0.1f);
            Unwraps("0.01").To(0.01f);
            Unwraps("0.001").To(0.001f);
            Unwraps("0.0001").To(0.0001f);
            Unwraps("0.00001").To(0.00001f);
            Unwraps("0.000001").To(0.000001f);
            Unwraps("0.0000001").To(0.0f);
            Unwraps("0.00000001").To(0.0f);
            Unwraps("0.000000001").To(0.0f);
            Unwraps("0.0000000001").To(0.0f);
            Unwraps("0.00000000001").To(0.0f);

            Unwraps("1.1").To(1.1f);
            Unwraps("1.12").To(1.12f);
            Unwraps("1.123").To(1.123f);
            Unwraps("1.1234").To(1.1234f);
            Unwraps("1.12345").To(1.12345f);
            Unwraps("1.123456").To(1.123456f);
            Unwraps("1.123456").To(1.123456f);

            Unwraps("11.1").To(11.1f);
            Unwraps("11.12").To(11.12f);
            Unwraps("11.123").To(11.123f);
            Unwraps("11.1234").To(11.1234f);
            Unwraps("11.12345").To(11.12345f);
            Unwraps("11.12345").To(11.12345f);
            Unwraps("11.12345").To(11.12345f);

            Unwraps("111.1").To(111.1f);
            Unwraps("111.12").To(111.12f);
            Unwraps("111.123").To(111.123f);
            Unwraps("111.1234").To(111.1234f);
            Unwraps("111.1234").To(111.1234f);
            Unwraps("111.1234").To(111.1234f);

            Unwraps("1111.1").To(1111.1f);
            Unwraps("1111.12").To(1111.12f);
            Unwraps("1111.123").To(1111.123f);
            Unwraps("1111.123").To(1111.123f);
            Unwraps("1111.123").To(1111.123f);

            Unwraps("11111.1").To(11111.1f);
            Unwraps("11111.12").To(11111.12f);
            Unwraps("11111.12").To(11111.12f);
            Unwraps("11111.12").To(11111.12f);

            Unwraps("111111.1").To(111111.1f);
            Unwraps("111111.1").To(111111.1f);
            Unwraps("111111.1").To(111111.1f);
            Unwraps("1111111.1").To(1111111.0f);

            Unwraps("1111111").To(1111111f);
            Unwraps("1111111E1").To(11111110f);
            Unwraps("1111111E2").To(111111100f);
            Unwraps("1111111E3").To(1111111000f);
            Unwraps("1111111E4").To(11111110000f);
            Unwraps("1111111E5").To(111111100000f);
            Unwraps("1111111E6").To(1111111000000f);
            Unwraps("1111111E7").To(11111110000000f);
            Unwraps("1111111E8").To(111111100000000f);
            Unwraps("1111111E9").To(1111111000000000f);
            Unwraps("1111111E10").To(11111110000000000f);
            Unwraps("1111111E11").To(111111100000000000f);
            Unwraps("1111111E12").To(1111111000000000000f);

            Unwraps("0.102").To(0.102f);
            Unwraps("0.1002").To(0.1002f);
            Unwraps("0.10203").To(0.10203f);
            Unwraps("0.102034").To(0.102034f);
            Unwraps("0.1020034").To(0.102003f);
            Unwraps("0.10200034").To(0.102f);
        }

        [Fact]
        public void Integer()
        {
            Unwraps("1").To(1);
            Unwraps("11").To(11);
            Unwraps("111").To(111);
            Unwraps("1111").To(1111);
            Unwraps("11111").To(11111);
            Unwraps("111111").To(111111);
            Unwraps("1111111").To(1111111);
            Unwraps("11111111").To(11111111);
            Unwraps("111111111").To(111111111);
            Unwraps("1111111111").To(1111111111);

            Assert.Equal(int.MaxValue - 1, (int.MaxValue - 1).ToString().AsJson<int>());
            Assert.Equal(int.MinValue + 1, (int.MinValue + 1).ToString().AsJson<int>());

            Assert.Equal(int.MaxValue, int.MaxValue.ToString().AsJson<int>());
            Assert.Equal(int.MinValue, int.MinValue.ToString().AsJson<int>());

            var rand = new Random(1111);
            for (var i = 0; i < 1000; i++)
            {
                var number = rand.Next();
                Assert.Equal(number, number.ToString().AsJson<int>());
            }
        }

        [Fact]
        public void Long()
        {
            Unwraps("1").To(1L);
            Unwraps("11").To(11L);
            Unwraps("111").To(111L);
            Unwraps("1111").To(1111L);
            Unwraps("11111").To(11111L);
            Unwraps("111111").To(111111L);
            Unwraps("1111111").To(1111111L);
            Unwraps("11111111").To(11111111L);
            Unwraps("111111111").To(111111111L);
            Unwraps("1111111111").To(1111111111L);
            Unwraps("11111111111").To(11111111111L);
            Unwraps("111111111111").To(111111111111L);
            Unwraps("1111111111111").To(1111111111111L);
            Unwraps("11111111111111").To(11111111111111L);
            Unwraps("111111111111111").To(111111111111111L);
            Unwraps("1111111111111111").To(1111111111111111L);
            Unwraps("11111111111111111").To(11111111111111111L);
            Unwraps("111111111111111111").To(111111111111111111L);
            Unwraps("1111111111111111111").To(1111111111111111111L);

            Assert.Equal(long.MaxValue - 1, (long.MaxValue - 1).ToString().AsJson<long>());
            Assert.Equal(long.MinValue + 1, (long.MinValue + 1).ToString().AsJson<long>());

            Assert.Equal(long.MaxValue, long.MaxValue.ToString().AsJson<long>());
            Assert.Equal(long.MinValue, long.MinValue.ToString().AsJson<long>());
        }

        [Fact]
        public void String()
        {
            Unwraps("\"0\"").To("0");
            Unwraps("\"Hello\"").To("Hello");
            Unwraps("\"Hello, guys!\"").To("Hello, guys!");
        }
        
        private static UnwrapsFluent Unwraps(string json)
        {
            return new UnwrapsFluent(json);
        }

        private struct UnwrapsFluent
        {
            private readonly string _json;

            public UnwrapsFluent(string json)
            {
                _json = json;
            }

            public void To<T>(T value)
            {
                Assert.Equal(value, _json.AsJson<T>());
            }

            public void To(int value)
            {
                Assert.Equal(value, _json.AsJson<int>());
                Assert.Equal(-value, ("-" + _json).AsJson<int>());
            }

            public void To(long value)
            {
                Assert.Equal(value, _json.AsJson<long>());
                Assert.Equal(-value, ("-" + _json).AsJson<long>());
            }
        }
    }
}