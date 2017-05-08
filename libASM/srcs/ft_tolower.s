section .text
global _ft_tolower

_ft_tolower:
	mov			eax, edi
	cmp			eax, 64
	jle			end
	cmp			eax, 91
	jge			end
	add			eax, 32

end:
	ret