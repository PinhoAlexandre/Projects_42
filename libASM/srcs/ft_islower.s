section .text
global	_ft_islower

_ft_islower:
	push		rbx
	mov			ebx, edi
	cmp			ebx, 'a'
	jge			lower_letter
	mov			eax, 0
	pop			rbx
	ret

lower_letter:
	cmp			ebx, 'z'
	jle			ok
	mov			eax, 0
	pop			rbx
	ret

ok:
	mov			eax, 1
	pop			rbx
	ret
