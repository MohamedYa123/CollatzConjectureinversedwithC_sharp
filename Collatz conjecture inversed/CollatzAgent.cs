﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Collatz_conjecture_inversed
{
    public static class CollatzAgent
    {
        public static (BigInteger,int) ConvertBytesTonumber(byte[] bytes)
        {
            int patternlength = 0;
            byte[] bts = new byte[4];
            for (int i = 0; i < 4; i++)
            {
                bts[i] = bytes[i];
            }
            
            byte[] otherbytes = new byte[bytes.Length - 4];
            for(int j = 4; j < bytes.Length; j++)
            {
                otherbytes[j - 4] = bytes[j];
            }
            patternlength= BitConverter.ToInt32(bytes, 0);
            BigInteger bc = new BigInteger(otherbytes);
            return (bc, patternlength);
        }
        public static byte[] ConvertpatternintoBytes(List<int> pattern,int inversed)
        {
            int sum = 0;
            for(int i = 0; i < pattern.Count; i++)
            {
                sum += pattern[i];
            }
            sum /= 8;
            int bytwhere = 0;
            int indexofbyte = 0;
            byte[] bytes = new byte[sum];
            int byten = 0;
            int with = 1;
            int with2 = 0;
            if (inversed < 0)
            {
                with = 0;
                with2 = 1;
            }
            for (int i = 0; i < pattern.Count; i++)
            {
                var pi = pattern[i];
                
                while (pi > 0)
                {
                    byten = byten << 1;
                    if (i % 2 == 1)
                    {
                        byten |= with;
                    }
                    else
                    {
                        byten |= with2;
                    }
                    pi--;
                    indexofbyte++;
                    if (indexofbyte == 8)
                    {
                        bytes[bytwhere] = (byte)byten;
                        indexofbyte =0;
                        byten = 0;
                        bytwhere++;
                    }
                    
                    
                }
            }
            //bytes[bytwhere] = (byte)byten;
            return bytes;
        }
        public static (List<int>,int) ConvertBytestoPattern(byte[] bytes)
        {
            List<int> Pattern = new List<int>();
            int lastturn = 0;
            int inversed = -1;
            int newnum = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                byte b = bytes[i];
                for(int j = 7; j >=0; j--)
                {
                    int bu = (b >> j);
                    int c = bu & 1;
                    if (lastturn == 0 && c == 0)
                    {
                        inversed = 1;
                    }
                    if (lastturn >= 0 && c > 0)
                    {
                        //if (newnum == 0)
                        {
                            lastturn += 1;
                        }
                    }
                    else if (c>0)
                    {
                        Pattern.Add(lastturn*-1);
                        lastturn = 1;
                        newnum = 1;
                        continue;
                    }
                    if (lastturn <= 0 && c == 0)
                    {
                       // if (newnum == 0)
                        {
                            lastturn -= 1;
                        }
                    }
                    else if (c == 0)
                    {
                        Pattern.Add(lastturn);
                        lastturn = -1;
                        newnum = 1;
                        continue;
                    }
                }
            }
            Pattern.Add(Math.Abs(lastturn));
            return (Pattern,inversed);
        }
        //Code written by Mohamed Yasser //
        //Email: mohamedyasser112025@gmail.com//
        public static List<int> ExtractPattern(BigInteger num,int G,int Patternlength,bool breakinsmaller=false)
        {
            BigInteger numt = num;
            List<int> Pattern = new List<int>();
            //Pattern.AddRange(new int[Patternlength]);
            while (Patternlength > 0)
            {
                int nz = 0;
                while ((num & 1) != 0)//odd
                {
                    num = (num * 3 + 1);
                    num = num >> 1;
                    Patternlength--;
                    nz++;
                }
                Pattern.Add(nz);
                if (Patternlength <= 0)
                {
                    break;
                }
                nz = 0;
                while ((num & 1) == 0)
                {
                    num = num >> 1;
                    Patternlength--;
                    nz++;
                }
                Pattern.Add(nz);
                if (breakinsmaller && num < numt)
                {
                    break;
                }
            }
            return Pattern;
        }
        static (BigInteger, BigInteger, BigInteger) extended_gcd(BigInteger A, BigInteger B,int depth)
        {
            if (A == 0)
            {
                return (B, 0, 1);
            }
            (BigInteger gcd, BigInteger x1, BigInteger y1) = extended_gcd(B % A, A, depth+1);
            BigInteger x = y1 - (B / A) * x1;
            BigInteger y = x1;
            return (gcd, x, y);
        }
       /* static (BigInteger gcd, BigInteger x, BigInteger y) ExtendedGCD(BigInteger A, BigInteger B)
        {
            BigInteger x0 = 1, y0 = 0;
            BigInteger x1 = 0, y1 = 1;
            int depth = 0;
            while (A != 0)
            {
                BigInteger q = B / A;
                BigInteger r = B % A;

                BigInteger xTemp = x1;
                BigInteger yTemp = y1;

                x1 = x0 - q * x1;
                y1 = y0 - q * y1;

                x0 = xTemp;
                y0 = yTemp;

                B = A;
                A = r;
                depth++;
            }

            return (B, x0, y0);
        }*/
        static (BigInteger gcd, BigInteger x, BigInteger y) ExtendedGCD(BigInteger a, BigInteger b)
        {
            BigInteger old_r = a, r = b;
            BigInteger old_s = BigInteger.One, s = BigInteger.Zero;
            BigInteger old_t = BigInteger.Zero, t = BigInteger.One;

            while (r != 0)
            {
                BigInteger quotient = old_r / r;

                (old_r, r) = (r, old_r - quotient * r);
                (old_s, s) = (s, old_s - quotient * s);
                (old_t, t) = (t, old_t - quotient * t);
            }

            // old_r = gcd, old_s = x, old_t = y
            return (old_r, old_s, old_t);
        }

        static BigInteger mod_inverse(BigInteger B,BigInteger A)
        {
            //(BigInteger gcd, BigInteger x, BigInteger y1) = extended_gcd(B, A,0);
            (BigInteger gcd, BigInteger x, BigInteger y1) = ExtendedGCD(B, A);
            if (gcd != 1)
            {
                return -1;
            }
            return x % A;
        }
        static BigInteger find_n(BigInteger A, BigInteger B, BigInteger C)
        {
            if (C % A == 0)
            {
                return 0;
            }
            BigInteger B_inv = mod_inverse(B, A);
            BigInteger n = (C * B_inv) % A;
            n = (n + A) % A;
            return n;
        }
        static BigInteger CheckAddedValue(BigInteger numt,int a,int np)
        {
            BigInteger A= BigInteger.Pow(2, a-1);
            BigInteger B= BigInteger.Pow(3, np);
            BigInteger numtsq = ((numt >> a) + 1);
            numtsq = numtsq << a;
            numtsq -= numt;
            BigInteger C = numtsq / 2;
            BigInteger adds = find_n(A, B, C);
            if (adds == 0)
            {
                adds = 1;
            }
            return adds;
        }
        public static int patternreached = 0;
        public static BigInteger FindNumberFromPattern(int G,List<int>Pattern)
        {
            BigInteger num = -G;
            BigInteger lastverifiednumt =-G;
            List<int> PatternVerified = new List<int>();
            for(int i = 0; i < Pattern.Count; i++)
            {
                PatternVerified.Add((i==0)?1:0);
            }
            while (num < G)
            {
                num += BigInteger.Pow(2, Pattern[0]);
                lastverifiednumt += BigInteger.Pow(3, Pattern[0]);
            }
            int np = 0;
            int nzs = 0;
            int stindex = 0;
            while (true)
            {
                BigInteger numt = lastverifiednumt;
                
                BigInteger adds = 0;
                for (int i = stindex; i < Pattern.Count; i++)
                {
                    patternreached = stindex;
                    int p = Pattern[i];
                    if (PatternVerified[i] == 1)
                    {
                        if (i % 2 == 0)
                        {
                            np += p;
                        }
                        nzs += p;
                        stindex++;
                        continue;
                    }
                    BigInteger dnumt = numt;
                    int nz = 0;
                    if (i % 2 == 0)
                    {
                        dnumt = numt + G;

                    }
                    BigInteger zn= dnumt;
                   // var f = dnumt & 1;
                    while ((dnumt & 1) == 0) {
                        dnumt = dnumt >> 1;
                        nz += 1;
                    }
                    if (nz == p)
                    {
                        lastverifiednumt = dnumt;
                        if (i % 2 == 0)
                        {
                            //odd
                            lastverifiednumt= BigInteger.Pow(3, nz)*dnumt-G;
                        }
                        PatternVerified[i] = 1;
                        break;
                    }
                    else
                    {
                        //you need to do adjustment
                        lastverifiednumt = numt;
                        adds = CheckAddedValue(zn, p, np);
                        break;
                    }
                }
                if (stindex >= Pattern.Count)
                {
                    break;
                }
                else
                {
                    num += 2 * adds * BigInteger.Pow(2, nzs);
                    lastverifiednumt += 2 * adds * BigInteger.Pow(3, np);
                }
            }
            patternreached = stindex;
            return num;
        }
    }
}
