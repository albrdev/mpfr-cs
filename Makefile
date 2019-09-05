.PHONY: dllpatch
dllpatch:
	@python ./mpfr-cs/dll_patcher.py ./mpfr-cs/bin/Debug/Math.Mpfr.Native.dll ./mpfr-cs/bin/Release/Math.Mpfr.Native.dll
