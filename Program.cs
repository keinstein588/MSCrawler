﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MSCrawlerApp
{
    class Program
    {
        static private Dictionary<string,int> ExcludedWords;
        static private int ReturnCount;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many words to return (Default 10):");
            if(!int.TryParse(Console.ReadLine(), out ReturnCount))
            {
                ReturnCount = 10;
            }
            Console.WriteLine("Enter a list of words to exclude from the results");
            ExcludedWords = BreakStringIntoWords(Console.ReadLine());

            //the following text taken from https://en.wikipedia.org/wiki/Microsoft
            //The coding challenge seemed to be more focused on the word counting than getting content from a webpage, making a web scraper to get this would have taken longer than I felt necessary for this application.
            string TextToParse = @"History
Main article: History of Microsoft
For a chronological guide, see Timeline of Microsoft.
1972–1985: Founding

An Altair 8800 computer (left) with the popular Model 33 ASR Teletype as terminal, paper tape reader, and paper tape punch

Paul Allen and Bill Gates on October 19, 1981, after signing a pivotal contract with IBM[11]: 228 

Bill Gates and Paul Allen's Original Business Cards located in the Microsoft Visitor Center.
Childhood friends Bill Gates and Paul Allen sought to make a business using their skills in computer programming.[12] In 1972, they founded Traf-O-Data, which sold a rudimentary computer to track and analyze automobile traffic data. Gates enrolled at Harvard University while Allen pursued a degree in computer science at Washington State University, though he later dropped out to work at Honeywell.[13] The January 1975 issue of Popular Electronics featured Micro Instrumentation and Telemetry Systems's (MITS) Altair 8800 microcomputer,[14] which inspired Allen to suggest that they could program a BASIC interpreter for the device. Gates called MITS and claimed that he had a working interpreter, and MITS requested a demonstration. Allen worked on a simulator for the Altair while Gates developed the interpreter, and it worked flawlessly when they demonstrated it to MITS in March 1975 in Albuquerque, New Mexico. MITS agreed to distribute it, marketing it as Altair BASIC.[11]: 108, 112–114  Gates and Allen established Microsoft on April 4, 1975, with Gates as CEO,[15] and Allen suggested the name ""Micro - Soft,"" short for micro-computer software.[16][17] In August 1977, the company formed an agreement with ASCII Magazine in Japan, resulting in its first international office of ASCII Microsoft.[18] Microsoft moved its headquarters to Bellevue, Washington, in January 1979.[15]

Microsoft entered the operating system(OS) business in 1980 with its own version of Unix called Xenix,[19] but it was MS-DOS that solidified the company's dominance. IBM awarded a contract to Microsoft in November 1980 to provide a version of the CP/M OS to be used in the IBM Personal Computer (IBM PC).[20] For this deal, Microsoft purchased a CP/M clone called 86-DOS from Seattle Computer Products which it branded as MS-DOS, although IBM rebranded it to IBM PC DOS. Microsoft retained ownership of MS-DOS following the release of the IBM PC in August 1981. IBM had copyrighted the IBM PC BIOS, so other companies had to reverse engineer it in order for non-IBM hardware to run as IBM PC compatibles, but no such restriction applied to the operating systems. Microsoft eventually became the leading PC operating systems vendor.[21][22]: 210  The company expanded into new markets with the release of the Microsoft Mouse in 1983, as well as with a publishing division named Microsoft Press.[11]: 232  Paul Allen resigned from Microsoft in 1983 after developing Hodgkin's lymphoma.[23] Allen claimed in Idea Man: A Memoir by the Co - founder of Microsoft that Gates wanted to dilute his share in the company when he was diagnosed with Hodgkin's disease because he did not think that he was working hard enough.[24] Allen later invested in low-tech sectors, sports teams, commercial real estate, neuroscience, private space flight, and more.[25]

1985–1994: Windows and Office

Windows 1.0 was released on November 20, 1985, as the first version of the Windows line.
Microsoft released Windows on November 20, 1985, as a graphical extension for MS - DOS,[11]: 242–243, 246 despite having begun jointly developing OS / 2 with IBM the previous August.[26] Microsoft moved its headquarters from Bellevue to Redmond, Washington, on February 26, 1986, and went public on March 13,[27] with the resulting rise in stock making an estimated four billionaires and 12,000 millionaires from Microsoft employees.[28] Microsoft released its version of OS/2 to original equipment manufacturers (OEMs) on April 2, 1987.[11] In 1990, the Federal Trade Commission examined Microsoft for possible collusion due to the partnership with IBM, marking the beginning of more than a decade of legal clashes with the government.[29] : 243–244  Meanwhile, the company was at work on Microsoft Windows NT, which was heavily based on their copy of the OS/2 code.It shipped on July 21, 1993, with a new modular kernel and the 32-bit Win32 application programming interface (API), making it easier to port from 16-bit(MS-DOS-based) Windows.Microsoft informed IBM of Windows NT, and the OS/2 partnership deteriorated.[30]

In 1990, Microsoft introduced the Microsoft Office suite which bundled separate applications such as Microsoft Word and Microsoft Excel.[11]: 301  On May 22, Microsoft launched Windows 3.0, featuring streamlined user interface graphics and improved protected mode capability for the Intel 386 processor,[31] and both Office and Windows became dominant in their respective areas.[32][33]

On July 27, 1994, the Department of Justice's Antitrust Division filed a competitive impact statement that said: ""Beginning in 1988 and continuing until July 15, 1994, Microsoft induced many OEMs to execute anti-competitive 'per processor licenses.Under a per-processor license, an OEM pays Microsoft a royalty for each computer it sells containing a particular microprocessor, whether the OEM sells the computer with a Microsoft operating system or a non-Microsoft operating system.In effect, the royalty payment to Microsoft when no Microsoft product is being used acts as a penalty, or tax, on the OEM's use of a competing PC operating system. Since 1988, Microsoft's use of per processor licenses has increased.""[34]

1995–2007: Foray into the Web, Windows 95, Windows XP, and Xbox


In 1996, Microsoft released Windows CE, a version of the operating system meant for personal digital assistants and other tiny computers, shown here on the HP 300LX.
Following Bill Gates's internal ""Internet Tidal Wave memo"" on May 26, 1995, Microsoft began to redefine its offerings and expand its product line into computer networking and the World Wide Web.[35] With a few exceptions of new companies, like Netscape, Microsoft was the only major and established company that acted fast enough to be a part of the World Wide Web practically from the start. Other companies like Borland, WordPerfect, Novell, IBM and Lotus, being much slower to adapt to the new situation, would give Microsoft market dominance.[36] The company released Windows 95 on August 24, 1995, featuring pre-emptive multitasking, a completely new user interface with a novel start button, and 32-bit compatibility; similar to NT, it provided the Win32 API.[37][38]: 20  Windows 95 came bundled with the online service MSN, which was at first intended to be a competitor to the Internet,[dubious – discuss] and (for OEMs) Internet Explorer, a Web browser. Internet Explorer has not bundled with the retail Windows 95 boxes, because the boxes were printed before the team finished the Web browser, and instead were included in the Windows 95 Plus! pack.[39] Backed by a high-profile marketing campaign[40] and what The New York Times called ""the splashiest, most frenzied, most expensive introduction of a computer product in the industry's history,""[41] Windows 95 quickly became a success.[42] Branching out into new markets in 1996, Microsoft and General Electric's NBC unit created a new 24/7 cable news channel, MSNBC.[43] Microsoft created Windows CE 1.0, a new OS designed for devices with low memory and other constraints, such as personal digital assistants.[44] In October 1997, the Justice Department filed a motion in the Federal District Court, stating that Microsoft violated an agreement signed in 1994 and asked the court to stop the bundling of Internet Explorer with Windows.[11]: 323–324 



Microsoft released the first installment in the Xbox series of consoles in 2001. The Xbox, graphically powerful compared to its rivals, featured a standard PC's 733 MHz Intel Pentium III processor.
On January 13, 2000, Bill Gates handed over the CEO position to Steve Ballmer, an old college friend of Gates and employee of the company since 1980, while creating a new position for himself as Chief Software Architect.[11]: 111, 228 [15] Various companies including Microsoft formed the Trusted Computing Platform Alliance in October 1999 to(among other things) increase security and protect intellectual property through identifying changes in hardware and software.Critics decried the alliance as a way to enforce indiscriminate restrictions over how consumers use software, and over how computers behave, and as a form of digital rights management: for example, the scenario where a computer is not only secured for its owner but also secured against its owner as well.[45][46] On April 3, 2000, a judgment was handed down in the case of United States v.Microsoft Corp., [47] calling the company an ""abusive monopoly.""[48] Microsoft later settled with the U.S.Department of Justice in 2004.[27] On October 25, 2001, Microsoft released Windows XP, unifying the mainstream and NT lines of OS under the NT codebase.[49] The company released the Xbox later that year, entering the video game console market dominated by Sony and Nintendo.[50] In March 2004 the European Union brought antitrust legal action against the company, citing it abused its dominance with the Windows OS, resulting in a judgment of €497 million ($613 million) and requiring Microsoft to produce new versions of Windows XP without Windows Media Player: Windows XP Home Edition N and Windows XP Professional N.[51][52] In November 2005, the company's second video game console, the Xbox 360, was released. There were two versions, a basic version for $299.99 and a deluxe version for $399.99.[53]


Increasingly present in the hardware business following Xbox, Microsoft 2006 released the Zune series of digital media players, a successor of its previous software platform Portable Media Center. These expanded on previous hardware commitments from Microsoft following its original Microsoft Mouse in 1983; as of 2007 the company sold the best-selling wired keyboard(Natural Ergonomic Keyboard 4000), mouse(IntelliMouse), and desktop webcam(LifeCam) in the United States.That year the company also launched the Surface ""digital table"", later renamed PixelSense.[54]

2007–2011: Microsoft Azure, Windows Vista, Windows 7, and Microsoft Stores

CEO Steve Ballmer at the MIX event in 2008. In an interview about his management style in 2005, he mentioned that his first priority was to get the people he delegates to in order. Ballmer also emphasized the need to continue pursuing new technologies even if initial attempts fail, citing the original attempts with Windows as an example.[55]

Headquarters of the European Commission, which has imposed several fines on Microsoft
Released in January 2007, the next version of Windows, Vista, focused on features, security and a redesigned user interface dubbed Aero.[56][57] Microsoft Office 2007, released at the same time, featured a ""Ribbon"" user interface which was a significant departure from its predecessors.Relatively strong sales of both products helped to produce a record profit in 2007.[58] The European Union imposed another fine of €899 million($1.4 billion) for Microsoft's lack of compliance with the March 2004 judgment on February 27, 2008, saying that the company charged rivals unreasonable prices for key information about its workgroup and backoffice servers.[59] Microsoft stated that it was in compliance and that ""these fines are about the past issues that have been resolved"".[60] 2007 also saw the creation of a multi-core unit at Microsoft, following the steps of server companies such as Sun and IBM.[61]

Gates retired from his role as Chief Software Architect on June 27, 2008, a decision announced in June 2006, while retaining other positions related to the company in addition to being an advisor for the company on key projects.[62][63] Azure Services Platform, the company's entry into the cloud computing market for Windows, launched on October 27, 2008.[64] On February 12, 2009, Microsoft announced its intent to open a chain of Microsoft-branded retail stores, and on October 22, 2009, the first retail Microsoft Store opened in Scottsdale, Arizona; the same day Windows 7 was officially released to the public. Windows 7's focus was on refining Vista with ease-of-use features and performance enhancements, rather than an extensive reworking of Windows.[65][66][67]

As the smartphone industry boomed in the late 2000s, Microsoft had struggled to keep up with its rivals in providing a modern smartphone operating system, falling behind Apple and Google-sponsored Android in the United States.[68] As a result, in 2010 Microsoft revamped their aging flagship mobile operating system, Windows Mobile, replacing it with the new Windows Phone OS that was released in October that year.[69][70] It used a new user interface design language, codenamed ""Metro,"" which prominently used simple shapes, typography, and iconography, utilizing the concept of minimalism.Microsoft implemented a new strategy for the software industry, providing a consistent user experience across all smartphones using the Windows Phone OS.It launched an alliance with Nokia in 2011 and Microsoft worked closely with the company to co-develop Windows Phone,[71] but remained partners with long-time Windows Mobile OEM HTC.[72] Microsoft is a founding member of the Open Networking Foundation started on March 23, 2011. Fellow founders were Google, HP Networking, Yahoo!, Verizon Communications, Deutsche Telekom and 17 other companies.This nonprofit organization is focused on providing support for a cloud computing initiative called Software-Defined Networking.[73] The initiative is meant to speed innovation through simple software changes in telecommunications networks, wireless networks, data centers, and other networking areas.[74]

2011–2014: Windows 8/8.1, Xbox One, Outlook.com, and Surface devices

Surface Pro 3, part of the Surface series of laplets by Microsoft
Following the release of Windows Phone, Microsoft undertook a gradual rebranding of its product range throughout 2011 and 2012, with the corporation's logos, products, services, and websites adopting the principles and concepts of the Metro design language.[75] Microsoft unveiled Windows 8, an operating system designed to power both personal computers and tablet computers, in Taipei in June 2011.[76] A developer preview was released on September 13, which was subsequently replaced by a consumer preview on February 29, 2012, and released to the public in May.[77] The Surface was unveiled on June 18, becoming the first computer in the company's history to have its hardware made by Microsoft.[78][79] On June 25, Microsoft paid US$1.2 billion to buy the social network Yammer.[80] On July 31, they launched the Outlook.com webmail service to compete with Gmail.[81] On September 4, 2012, Microsoft released Windows Server 2012.[82]

In July 2012, Microsoft sold its 50% stake in MSNBC, which it had run as a joint venture with NBC since 1996.[83] On October 1, Microsoft announced its intention to launch a news operation, part of a new-look MSN, with Windows 8 later in the month.[84] On October 26, 2012, Microsoft launched Windows 8 and the Microsoft Surface.[79][85] Three days later, Windows Phone 8 was launched.[86] To cope with the potential for an increase in demand for products and services, Microsoft opened a number of ""holiday stores"" across the U.S.to complement the increasing number of ""bricks-and-mortar"" Microsoft Stores that opened in 2012.[87] On March 29, 2013, Microsoft launched a Patent Tracker.[88]

In August 2012, the New York City Police Department announced a partnership with Microsoft for the development of the Domain Awareness System which is used for Police surveillance in New York City.[89]


The Xbox One console, released in 2013
The Kinect, a motion-sensing input device made by Microsoft and designed as a video game controller, first introduced in November 2010, was upgraded for the 2013 release of the Xbox One video game console. Kinect's capabilities were revealed in May 2013: an ultra-wide 1080p camera, function in the dark due to an infrared sensor, higher-end processing power and new software, the ability to distinguish between fine movements (such as a thumb movement), and determining a user's heart rate by looking at their face.[90] Microsoft filed a patent application in 2011 that suggests that the corporation may use the Kinect camera system to monitor the behavior of television viewers as part of a plan to make the viewing experience more interactive.On July 19, 2013, Microsoft stocks suffered their biggest one-day percentage sell-off since the year 2000, after its fourth-quarter report raised concerns among investors on the poor showings of both Windows 8 and the Surface tablet. Microsoft suffered a loss of more than US$32 billion.[91]

In line with the maturing PC business, in July 2013, Microsoft announced that it would reorganize the business into four new business divisions, namely Operating systems, Apps, Cloud, and Devices.All previous divisions will be dissolved into new divisions without any workforce cuts.[92] On September 3, 2013, Microsoft agreed to buy Nokia's mobile unit for $7 billion,[93] following Amy Hood taking the role of CFO.[94]

2014–2020: Windows 10, Microsoft Edge, and HoloLens

Satya Nadella succeeded Steve Ballmer as the CEO of Microsoft in February 2014.
On February 4, 2014, Steve Ballmer stepped down as CEO of Microsoft and was succeeded by Satya Nadella, who previously led Microsoft's Cloud and Enterprise division.[95] On the same day, John W. Thompson took on the role of chairman, in place of Bill Gates, who continued to participate as a technology advisor.[96] Thompson became the second chairman in Microsoft's history.[97] On April 25, 2014, Microsoft acquired Nokia Devices and Services for $7.2 billion.[98] This new subsidiary was renamed Microsoft Mobile Oy.[99] On September 15, 2014, Microsoft acquired the video game development company Mojang, best known for Minecraft, for $2.5 billion.[100] On June 8, 2017, Microsoft acquired Hexadite, an Israeli security firm, for $100 million.[101][102]

On January 21, 2015, Microsoft announced the release of their first Interactive whiteboard, Microsoft Surface Hub.[103] On July 29, 2015, Windows 10 was released, [104] with its server sibling, Windows Server 2016, released in September 2016. In Q1 2015, Microsoft was the third largest maker of mobile phones, selling 33 million units (7.2% of all). While a large majority(at least 75%) of them do not run any version of Windows Phone— those other phones are not categorized as smartphones by Gartner – in the same time frame 8 million Windows smartphones(2.5% of all smartphones) were made by all manufacturers(but mostly by Microsoft).[105] Microsoft's share of the U.S. smartphone market in January 2016 was 2.7%.[106] During the summer of 2015 the company lost $7.6 billion related to its mobile-phone business, firing 7,800 employees.[107]

On March 1, 2016, Microsoft announced the merger of its PC and Xbox divisions, with Phil Spencer announcing that Universal Windows Platform(UWP) apps would be the focus for Microsoft's gaming in the future.[108] On January 24, 2017, Microsoft showcased Intune for Education at the BETT 2017 education technology conference in London.[109] Intune for Education is a new cloud-based application and device management service for the education sector.[110] In May 2016, the company announced it was laying off 1,850 workers, and taking an impairment and restructuring charge of $950 million.[107] In June 2016, Microsoft announced a project named Microsoft Azure Information Protection. It aims to help enterprises protect their data as it moves between servers and devices.[111] In November 2016, Microsoft joined the Linux Foundation as a Platinum member during Microsoft's Connect(); developer event in New York.[112]
    The cost of each Platinum membership is US$500,000 per year.[113]
    Some analysts deemed this unthinkable ten years prior, however, as in 2001 then-CEO Steve Ballmer called Linux ""cancer"".[114]
    Microsoft planned to launch a preview of Intune for Education ""in the coming weeks,"" with general availability scheduled for spring 2017, priced at $30 per device, or through volume licensing agreements.[115]


    The Nokia Lumia 1320, the Microsoft Lumia 535 and the Nokia Lumia 530, which all run on one of the now-discontinued Windows Phone operating systems
In January 2018, Microsoft patched Windows 10 to account for CPU problems related to Intel's Meltdown security breach. The patch led to issues with the Microsoft Azure virtual machines reliant on Intel's CPU architecture. On January 12, Microsoft released PowerShell Core 6.0 for the macOS and Linux operating systems.[116]
    In February 2018, Microsoft killed notification support for their Windows Phone devices which effectively ended firmware updates for the discontinued devices.[116]
    In March 2018, Microsoft recalled Windows 10 S to change it to a mode for the Windows operating system rather than a separate and unique operating system. In March the company also established guidelines that censor users of Office 365 from using profanity in private documents.[116] In April 2018, Microsoft released the source code for Windows File Manager under the MIT License to celebrate the program's 20th anniversary. In April the company further expressed willingness to embrace open source initiatives by announcing Azure Sphere as its own derivative of the Linux operating system.[116] In May 2018, Microsoft partnered with 17 American intelligence agencies to develop cloud computing products. The project is dubbed ""Azure Government"" and has ties to the Joint Enterprise Defense Infrastructure (JEDI) surveillance program.[116] On June 4, 2018, Microsoft officially announced the acquisition of GitHub for $7.5 billion, a deal that closed on October 26, 2018.[117][118] On July 10, 2018, Microsoft revealed the Surface Go platform to the public. Later in the month, it converted Microsoft Teams to gratis.[116] In August 2018, Microsoft released two projects called Microsoft AccountGuard and Defending Democracy. It also unveiled Snapdragon 850 compatibility for Windows 10 on the ARM architecture.[119][120][116]


Apollo 11 astronaut Buzz Aldrin using a Microsoft HoloLens mixed reality headset in September 2016
In August 2018, Toyota Tsusho began a partnership with Microsoft to create fish farming tools using the Microsoft Azure application suite for Internet of things(IoT) technologies related to water management.Developed in part by researchers from Kindai University, the water pump mechanisms use artificial intelligence to count the number of fish on a conveyor belt, analyze the number of fish, and deduce the effectiveness of water flow from the data the fish provide.The specific computer programs used in the process fall under the Azure Machine Learning and the Azure IoT Hub platforms.[121] In September 2018, Microsoft discontinued Skype Classic.[116] On October 10, 2018, Microsoft joined the Open Invention Network community despite holding more than 60,000 patents.[122] In November 2018, Microsoft agreed to supply 100,000 Microsoft HoloLens headsets to the United States military in order to ""increase lethality by enhancing the ability to detect, decide and engage before the enemy.""[123] In November 2018, Microsoft introduced Azure Multi-Factor Authentication for Microsoft Azure.[124] In December 2018, Microsoft announced Project Mu, an open source release of the Unified Extensible Firmware Interface (UEFI) core used in Microsoft Surface and Hyper-V products. The project promotes the idea of Firmware as a Service.[125] In the same month, Microsoft announced the open source implementation of Windows Forms and the Windows Presentation Foundation (WPF) which will allow for further movement of the company toward the transparent release of key frameworks used in developing Windows desktop applications and software. December also saw the company discontinue the Microsoft Edge project in favor of Chromium backends for their browsers.[124]

On February 20, 2019, Microsoft Corp said it will offer its cyber security service AccountGuard to 12 new markets in Europe including Germany, France and Spain, to close security gaps and protect customers in political space from hacking.[126] In February 2019, hundreds of Microsoft employees protested the company's war profiteering from a $480 million contract to develop virtual reality headsets for the United States Army.[127]

2020–present: Acquisitions, Xbox Series X/S, and Windows 11
See also: Acquisition of Activision Blizzard by Microsoft
On March 26, 2020, Microsoft announced it was acquiring Affirmed Networks for about $1.35 billion.[128][129] Due to the COVID-19 pandemic, Microsoft closed all of its retail stores indefinitely due to health concerns.[130] On July 22, 2020, Microsoft announced plans to close its Mixer service, planning to move existing partners to Facebook Gaming.[131]

On July 31, 2020, it was reported that Microsoft was in talks to acquire TikTok after the Trump administration ordered ByteDance to divest ownership of the application to the U.S.[132] On August 3, 2020, after speculation on the deal, Donald Trump stated that Microsoft could buy the application, however, it should be completed by September 15, 2020, and that the United States Department of the Treasury should receive a portion if it were to go through.[133]

On August 5, 2020, Microsoft stopped its xCloud game streaming test for iOS devices. According to Microsoft, the future of xCloud on iOS remains unclear and potentially out of Microsoft's hands. Apple has imposed a strict limit on ""remote desktop clients"" which means applications are only allowed to connect to a user-owned host device or gaming console owned by the user.[134] On September 21, 2020, Microsoft announced its intent to acquire video game company ZeniMax Media, the parent company of Bethesda Softworks, for about $7.5 billion, with the deal expected to occur in the second half of 2021 fiscal year.[135] On March 9, 2021, the acquisition was finalized and ZeniMax Media became part of Microsoft's Xbox Game Studios division.[136] The total price of the deal was $8.1 billion.[137]

On September 22, 2020, Microsoft announced that it had an exclusive license to use OpenAI's GPT-3 artificial intelligence language generator.[138] The previous version of GPT-3, called GPT-2, made headlines for being ""too dangerous to release"" and had numerous capabilities, including designing websites, prescribing medication, answering questions, and penning articles.[139] On November 10, 2020, Microsoft released the Xbox Series X and Xbox Series S video game consoles.[140]

In April 2021, Microsoft announced it would buy Nuance Communications for approximately $16 billion.[141] The acquisition of Nuance was completed in March 2022.[142] In 2021, in part due to the strong quarterly earnings spurred by the COVID-19 pandemic, Microsoft's valuation came to nearly $2 trillion. The increased necessity for remote work and distance education drove demand for cloud computing and grew the company's gaming sales.[143][144][145]

On June 24, 2021, Microsoft announced Windows 11 during a Livestream.The announcement came with confusion after Microsoft announced Windows 10 would be the last version of the operating system; set to be released in the third quarter of 2021.[146] It was released to the general public on October 5, 2021.[147]

    In early September 2021, it was announced that the company had acquired Takelessons, an online platform which connects students and tutors in numerous subjects.The acquisition positioned Microsoft to grow its presence in the market of providing online education to large numbers of people.[148] In the same month, Microsoft acquired Australia-based video editing software company Clipchamp.[149]

In October 2021, Microsoft announced that it began rolling out end-to-end encryption (E2EE) support for Microsoft Teams calls in order to secure business communication while using video conferencing software.Users can ensure that their calls are encrypted and can utilize a security code that both parties on a call must verify on their respective ends.[150] On October 7, Microsoft acquired Ally.io, a software service that measures companies' progress against OKRs. Microsoft plans to incorporate Ally.io into its Viva family of employee experience products.[151]

On January 18, 2022, Microsoft announced the acquisition of American video game developer and holding company Activision Blizzard in an all-cash deal worth $68.7 billion.[152] Activision Blizzard is best known for producing franchises, including but not limited to Warcraft, Diablo, Call of Duty, StarCraft, Candy Crush Saga, Crash Bandicoot, Spyro the Dragon, Skylanders, and Overwatch.[153] Activision and Microsoft each released statements saying the acquisition was to benefit their businesses in the metaverse, many saw Microsoft's acquisition of video game studios as an attempt to compete against Meta Platforms, with TheStreet referring to Microsoft wanting to become ""the Disney of the metaverse"".[154][155] Microsoft has not released statements regarding Activision's recent legal controversies regarding employee abuse, but reports have alleged that Activision CEO Bobby Kotick, a major target of the controversy, will leave the company after the acquisition is finalized.[156] The deal was closed on October 13, 2023.[157]

In December 2022, Microsoft announced a new 10-year deal with the London Stock Exchange for products including Microsoft Azure; Microsoft acquired ~4% of the LSE as part of the deal.[158]

In January 2023, CEO Satya Nadella announced Microsoft would lay off some 10,000 employees.[159] The announcement came a day after hosting a Sting concert for 50 people, including Microsoft executives, in Davos, Switzerland.[160]

On January 23, 2023, Microsoft announced a new multi-year, multi-billion dollar investment deal with ChatGPT developer OpenAI.[161]";


            var WordCounts = BreakStringIntoWords(TextToParse).OrderByDescending(x=>x.Value);
            int i = 0;
            foreach (KeyValuePair<string,int> wordcount in WordCounts)
            {
                if (ExcludedWords.ContainsKey(wordcount.Key)) continue;
                Console.WriteLine(wordcount.Key + "\t" + wordcount.Value);
                ++i;
                if (i >= ReturnCount) break;
            }
        }

        static Dictionary<string,int> BreakStringIntoWords (string input)
        {
            string[] words = input.Split(new char[] { ' ', ',', '.', '\n', '\r', '-' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> ReturnedWords = new Dictionary<string, int>();
            foreach (string word in words)
            {
                //Potential optimization: if hasing string is faster than string comparison, change dictionary to int,int and use hash as key.
                if (ReturnedWords.ContainsKey(word))
                {
                    ReturnedWords[word]++;
                }
                else
                {
                    ReturnedWords.Add(word, 1);
                }
            }
            return ReturnedWords;
        }
    }
}
