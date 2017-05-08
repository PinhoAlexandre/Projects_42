section .text
global _ft_isalnum

_ft_isalnum:
	push	rbx
	mov		ebx, edi
	cmp		ebx, 'a'
	jge		min_letter
	cmp		ebx, 'A'
	jge		max_letter
	cmp		ebx, '0'
	jge		int
	mov		eax, 0
	pop		rbx
	ret

min_letter:
	cmp		ebx, 'z'
	jle		true
	mov		eax, 0
	pop		rbx
	ret

max_letter:
	cmp		ebx, 'Z'
	jle		true
	mov		eax, 0
	pop		rbx
	ret

int:
	cmp		ebx, '9'
	jle 	true
	mov		eax, 0
	pop		rbx
	ret

true:
	mov		eax, 1
	pop		rbx
	ret