section .text
global _ft_toupper

_ft_toupper:
		mov		eax, edi
		cmp		eax, 96
		jle		end
		cmp		eax, 123
		jge		end
		sub		eax, 32

end:
		ret
		