
## Computer Setting:
+ Operating Machine: Windows 10 (version 1809)
+ Monitor Size: 1920 × 1080
+ This experimental program was coded in Visual Studio 2019 (Visual Basic, Form Application). I strongly recommend downloading Visual Studio 2019 to use in the same environment.
+ This program built by modifying the previous experiment: https://github.com/YNakawake/projectile_neg/tree/main/experiment_program
+ zip file `Expermental_Program.zip` contains all items uploaded under this directory

## How to use:
+ 1. How to execute the program: 
  + You can launch the program in two ways. 
  + (a) Open 'Projectile.sln' with Visual Studio 2019, then press the 'Start' button (with a green triangle icon). 
  + (b) Alternatively, you can launch directly without using Visual Studio 2019, by double-clicking “\Projectile_test\bin\Projectile_test.exe”. The programme is unlikely to be launched if you did not download Visual Studio 2019 (since it requires 'Microsoft .Net Framework' or maybe other applications downloaded together with Visual Studio 2019). The program is only excusable on Windows PC. I guess that this program can be executable with other versions of Windows 10 but I have not checked it.

+ 2. How to set the condition and start trials?:
  + When you launch the program, the screen for the condition setting appears. Here, you can choose options such as: 'IND', 'OBL', 'VER'; which correspond to 'asocial', 'unrepaid', 'repaid' conditions, respectively. However, the program is identical.
  + To set the generation, you can do so by choosing one of the radio buttons next to the label 'Gen' (1: the first generation, 2: the second generation; although we did not use there is also the option for the third generation). 
  + If you choose '2', which means the second generation, you should input three parameters from the first generation in the same generations.
  + Note, you have to transmit information manually (by memorizing the parameters of the first generation and manually inputting).
  + (長さ: Length, 幅広さ: Width, 暑さ: Thickness)

+ 3. How to terminate the program:
  + After participants finish all 50 trials, you can terminate by pressing 'alt'+'F4'.
  + Please do not forget to memorize the final arrowhead, although you could access this information in the textfile in `Projectile_test/OutData`

+ 4. How can I use it in other languages?
  + Unfortunately, only the Japanese version is available. To translate, you could only change by re-writing the source code: by replacing Japanese texts inside the source code.

+ 5. How can I get the output
  + The data is available in the “\Projectile_test\OutData” folder. The output file is created with each participant with the “ID” you input initially. 
