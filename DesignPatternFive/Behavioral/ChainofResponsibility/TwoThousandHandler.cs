using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.Behavioral.ChainofResponsibility
{
    public class TwoThousandHandler : Handler
    {
        
        public override void DispatchMoney(long requestedAmount)
        {
            long numberOfNotesToDispatched = requestedAmount / 2000;

            if(numberOfNotesToDispatched>0)
            {
                if(numberOfNotesToDispatched>1)
                {
                    Console.WriteLine(numberOfNotesToDispatched +"Two Thousand notes are dispatched by TwoThousand");

                }
                else
                {
                    Console.WriteLine(numberOfNotesToDispatched + "Two Thousand notes are dispatched by TwoThousand");
                }
            }

            long pendingAmountTobeProcessed = requestedAmount % 2000;
            if (pendingAmountTobeProcessed>0)
            {
                NextHandler.DispatchMoney(pendingAmountTobeProcessed);
            }

        }
    }
}
