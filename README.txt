Clandestine/Codelord cipher pair (Cl2)
======================================

This repository contains the clandestine/codelord twin ciphers I created when I 
had a great passion towards cryptology (but had only some slight knowledge). 
At the time, the only programming language I knew was Visual Basic (VB96 and 
then migrated to .NET which this was coded in) an since I was a self-taught 
programmer, I was not familiar about good practices and testing. Writing the 
code took about 3 months and I never even ran the code once during that period 
so the debugging and manual testing of the code took another 2 months. Anyways, 
after it was finalized, the algorithm was a solid block cipher and a GUI has 
never been created. (I was working on another project which was to use Cl2 as 
a library but was never completed.) So after more than a year, I decided to 
create a small application which benchmarks the Cl2 algorithms. 
These algorithms are based on classic cryptography used on the binary alphabet. 

I decided to publish these after many years to archive them and with the idea 
that they might someday be useful to someone. Contributions are not accepted. 

All files in the `Core` folder except `.gitignore` date back to 2010. 
All files in the `cl2tester` folder except `.gitignore` date back to 2011. 

When I released the binaries on a blog or website I had at the time, I tweeted 
the benchmark results. The same description is displayed below. 

.:: #clandestine ::.
Passwords upto 281474976710656+ chars (Unicode).
Key files upto 72057594037927936+ bytes.
℮ 532 kB/s for Encryption #c1
℮ 543 kB/s for Decryption #c1

.:: #codelord ::.
Any number of chars.
Key files of any length.
℮ 603 kB/s for Encryption #c2
℮ 608 kB/s for Decryption #c2

Estimated using 1MB Blocks and 1KB Keys.
Speed will depend on the speed of the computer.

℮ #c1 and ℮ #c2 are based on a computer with 1.60 GHz Dual CPU (WEI 4.9) + 1.0 GB RAM (WEI 4.5)

Please send statistics information after testing to umstek@live.com
N.B. :
[1]. codelord is the best cipher. 
[2]. Minimum length of the password/key will be 2 Chars(Unicode) / 4 bytes. 
[3]. This cipher is solid; So you should break files into blocks. 
[4]. WARNING: Do not use keys longer than 4 kB. 
[5]. WARNING: Do not use blocks longer than 4 MB. 
[6]. This is an Alpha release. Tested under control conditions.

* The reason for the naming of the ciphers shall remain unknown. 
