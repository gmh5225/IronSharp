﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace IronSharp.CVE
{
    internal class CVE_2020_0683
    {
        public static void Check(int buildnumber, List<int> installedkblist)
        {
            var vulnkblist = new List<int>();
            switch (buildnumber)
            {
                case 10240:
                    vulnkblist.AddRange(new int[] {
                        4537776, 4540693, 4550930, 4556826, 4561649,
                        4567518, 4565513, 4571692, 4577049
                    });
                    break;
                case 14393:
                    vulnkblist.AddRange(new int[] {
                        4537764, 4537806, 4540670, 4541329, 4550929,
                        4550947, 4556813, 4561616, 4567517, 4565511,
                        4571694, 4577015
                    });
                    break;
                case 16299:
                    vulnkblist.AddRange(new int[] {
                        4537789, 4537816, 4540681, 4541330, 4554342,
                        4550927, 4556812, 4561602, 4567515, 4565508,
                        4571741, 4577041
                    });
                    break;
                case 17134:
                    vulnkblist.AddRange(new int[] {
                        4537762, 4537795, 4540689, 4541333, 4554349,
                        4550922, 4550944, 4556807, 4561621, 4567514,
                        4565489, 4571709, 4577032
                    });
                    break;
                case 17763:
                    vulnkblist.AddRange(new int[] {
                        4532691, 4537818, 4538461, 4541331, 4554354,
                        4549949, 4550969, 4551853, 4561608, 4567513,
                        4558998, 4559003, 4565349, 4571748, 4570333,
                        4577069
                    });
                    break;
                case 18362:
                    vulnkblist.AddRange(new int[] {
                        4532693, 4535996, 4540673, 4541335, 4551762,
                        4554364, 4549951, 4550945, 4556799, 4560960,
                        4567512, 4565483, 4559004, 4565351, 4566116,
                        4574727, 4577062
                    });
                    break;
                case 18363:
                    vulnkblist.AddRange(new int[] {
                        4532693, 4535996, 4540673, 4541335, 4551762,
                        4554364, 4549951, 4550945, 4556799, 4560960,
                        4567512, 4565483, 4559004, 4565351, 4566116,
                        4574727, 4577062
                    });
                    break;
                default:
                    break;
            }
            if (vulnkblist.Intersect(installedkblist).Any())
            {
                Console.WriteLine("Vulnerable for CVE-2020-0683");
            }
        }
    }
}
