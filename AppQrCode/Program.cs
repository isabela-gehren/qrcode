﻿namespace AppQrCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var QrcodeTextContent = @"I can't win, I can't reign
I will never win this game
Without you
Without you
I am lost, I am vain
I will never be the same
Without you
Without you

I won't run, I won't fly
I will never make it by
Without you
Without you
I can't rest, I can't fight
All I need is you and I
Without you
Without you

Oh oh oh!
You! You! You!
Without
You! You! You!
Without you

Can't erase, so I'll take blame
But I can't accept that we're estranged
Without you
Without you
I can't quit now, this can't be right
I can't take one more sleepless night
Without you
Without you

I won't soar, I won't climb
If you're not here, I'm paralyzed
Without you
Without you
I can't look, I'm so blind
I lost my heart, I lost my mind
Without you
Without you

Oh oh oh!
You! You! You!
Without
You! You! You!
Without you

I am lost, I am vain
I will never be the same
Without you
Without you
Without you";
            GenerateQRText.Generate(QrcodeTextContent, "qt_dguet");

            var tst = "https://raw.githubusercontent.com/isabela-gehren/diadosnamorados/master/IMG_20200611_234201_941.jpg";
            GenerateQRLink.Generate(tst, "link");
        }
    }
}
