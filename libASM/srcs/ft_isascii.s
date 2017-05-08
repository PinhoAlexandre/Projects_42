section .text
global _ft_isascii

_ft_isascii:
	push	rbx
	mov		ebx, edi
	cmp		ebx, 128
	jge		error
	cmp		ebx, -1
	jle		error
	mov		eax, 1
	pop		rbx
	ret

error:
	mov		eax, 0
	pop		rbx
	ret