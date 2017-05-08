section .text
global	_ft_isalpha

_ft_isalpha:
	push		rbx
	mov			ebx, edi
	cmp			ebx, 'a'
	jge			min_letter
	cmp			ebx, 'A'
	jge			max_letter
	mov			eax, 0
	pop			rbx
	ret


max_letter:
	cmp			ebx, 'Z'
	jle			ok
	mov			eax, 0
	pop			rbx
	ret


min_letter:
	cmp			ebx, 'z'
	jle			ok
	mov			eax, 0
	pop			rbx
	ret

ok:
	mov			eax, 1
	pop			rbx
	ret