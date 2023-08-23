using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.ChainofResponsibility
{
    public class FiveHounderdHandler : Handler
    {
        public override void DispatchMoney(long requestedAmount)
        {
            long numberOfNotesToDispatched = requestedAmount / 500;

            if (numberOfNotesToDispatched > 0)
            {
                if (numberOfNotesToDispatched > 1)
                {
                    Console.WriteLine(numberOfNotesToDispatched + "Five houndred notes are dispatched by TwoThousand");

                }
                else
                {
                    Console.WriteLine(numberOfNotesToDispatched + "Five houndred notes are dispatched by TwoThousand");
                }
            }

            long pendingAmountTobeProcessed = requestedAmount % 500;
            if (pendingAmountTobeProcessed > 0)
            {
                NextHandler.DispatchMoney(pendingAmountTobeProcessed);
            }

        }
    }
}
