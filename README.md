# Cpp-Modules-VS15-IDE-Support
This is a naive and simple integration of c++ modules to VS15 Update 1.

What's included:
* Syntax highlighting for the "import", "export" and "module" keywords (intellisense squiggle still appears ): )
* C++ modules project template
* C++ interface module item template
* (Naive) Pre-build script to first compile all .ixx in each project directory
  - Will probably have build-order problems with modules importing other modules
  - if someone could make a .targets file out of this it will be awesome!
  
I recommend turning on intellisense on .ixx files via tools->options->Text Editor->File Extension (ixx, Visual c++)

I ship this in its beta stage for you guys to tinker with, and to make modules usage more convenient.
Pull request / fork if needed.
