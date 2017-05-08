section .text
global	_ft_isupper

_ft_isupper:
	push		rbx
	mov			ebx, edi
	cmp			ebx, 'A'
	jge			upper_letter
	mov			eax, 0
	pop			rbx
	ret

upper_letter:
	cmp			ebx, 'Z'
	jle			ok
	mov			eax, 0
	pop			rbx
	ret

ok:
	mov			eax, 1
	pop			rbx
	ret
