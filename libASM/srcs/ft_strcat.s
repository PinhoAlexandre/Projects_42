section .text
global _ft_strcat

_ft_strcat:
	push		rbx
	push		rcx
	mov			rbx, rdi
	mov			rcx, rsi

while:
	cmp byte	[rbx], 0
	je			concat
	add			rbx, 1
	jmp			while

concat:
	cmp byte	[rcx], 0
	je			end
	mov			rax, [rcx]
	mov			[rbx], al
	add			rcx, 1
	add			rbx, 1
	jmp			concat

end:
	mov	byte	[rbx], 0
	mov			rax, rdi
	pop			rcx
	pop			rbx
	ret