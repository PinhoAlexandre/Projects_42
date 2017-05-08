section .text
global _ft_isprint

_ft_isprint:
	push	rbx
	mov		ebx, edi
	cmp		ebx, 127
	jge		error
	cmp		ebx, 31
	jle		error
	mov		eax, 1
	pop		rbx
	ret

error:
	mov		eax, 0
	pop		rbx
	ret