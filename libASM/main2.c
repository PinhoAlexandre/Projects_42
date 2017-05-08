/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   main2.c                                            :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: apinho <marvin@42.fr>                      +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2015/06/04 19:02:32 by apinho            #+#    #+#             */
/*   Updated: 2015/06/04 19:02:34 by apinho           ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include "libasm.h"
#include <string.h>
#include <fcntl.h>

int main(void)
{
	printf("/////////////// FT_CAT ///////////////\n");

	int fd = open("Makefile", O_RDONLY);
	ft_cat(fd);
	close(fd);

	int		digit = '5';
	int		alpha = 'H';

	printf("\n\n\n/////////////// FT_ISDIGIT ///////////////\n");
	printf("ft_isdigit(%c) = %d\n", digit, ft_isdigit(digit));
	printf("ft_isdigit(%c) = %d\n\n\n", alpha, ft_isdigit(alpha));

	printf("/////////////// FT_ISALPHA ///////////////\n");
	printf("ft_isalpha(%c) = %d\n", digit, ft_isalpha(digit));
	printf("ft_isalpha(%c) = %d\n\n\n", alpha, ft_isalpha(alpha));

	printf("/////////////// FT_ISASCII ///////////////\n");
	printf("ft_isascii(-1) = %d\n", ft_isascii(-1));
	printf("ft_isascii(42) = %d\n", ft_isascii(42));
	printf("ft_isascii(128) = %d\n\n\n", ft_isascii(128));

	int		ascii_del = 127; /* 127 = del*/
	int		ascii_dc4 = 20; /* 20 = dc4 */
	int		spc = ' ';
	int 	newline = 12;

	printf("/////////////// FT_ISPRINT ///////////////\n");
	printf("ft_isprint(%c) = %d\n", digit, ft_isprint(digit));
	printf("ft_isprint(%c) = %d\n", alpha, ft_isprint(alpha));
	printf("ft_isprint(%c) = %d\n", spc, ft_isprint(spc));
	printf("ft_isprint('dc4') = %d\n", ft_isprint(ascii_dc4));
	printf("ft_isprint('del') = %d\n\n\n", ft_isprint(ascii_del));

	printf("/////////////// FT_ISALNUM ///////////////\n");
	printf("ft_isalnum(%c) = %d\n", digit, ft_isalnum(digit));
	printf("ft_isalnum(%c) = %d\n", alpha, ft_isalnum(alpha));
	printf("ft_isalnum(%c) = %d\n\n\n", spc, ft_isalnum(spc));

	printf("/////////////// FT_ISSPACE ///////////////\n");
	printf("ft_isspace(%c) = %d\n", spc, ft_isspace(spc));
	printf("ft_isspace(%c) = %d\n", newline, ft_isspace(newline));
	printf("ft_isspace(%c) = %d\n\n\n", digit, ft_isspace(digit));

	int		maj = 'Z';
	int		min = 'z';

	printf("/////////////// FT_TOUPPER ///////////////\n");
	printf("ft_toupper(%c) = %c\n", maj, ft_toupper(maj));
	printf("ft_toupper(%c) = %c\n\n\n", min, ft_toupper(min));

	printf("/////////////// FT_TOLOWER ///////////////\n");
	printf("ft_tolower(%c) = %c\n", maj, ft_tolower(maj));
	printf("ft_tolower(%c) = %c\n\n\n", min, ft_tolower(min));

	printf("/////////////// FT_ISLOWER ///////////////\n");
	printf("ft_islower(%c) = %d\n", maj, ft_islower(maj));
	printf("ft_islower(%c) = %d\n\n\n", min, ft_islower(min));

	printf("/////////////// FT_ISUPPER ///////////////\n");
	printf("ft_isupper(%c) = %d\n", maj, ft_isupper(maj));
	printf("ft_isupper(%c) = %d\n\n\n", min, ft_isupper(min));

	char	*len = "01234";

	printf("/////////////// FT_STRLEN ///////////////\n");
	printf("ft_strlen(%s) = %zu\n\n\n", len, ft_strlen(len));

	char	str[] = "Jean-Jacques";

	printf("/////////////// FT_BZERO ///////////////\n");
	printf("str = %s\n", str);
	ft_bzero(str + 4, 8);
	printf("ft_bzero(\"Jean-Jacques\" + 4, 8) = %s\n\n\n", str);

	char	str1[] = "Cou";
	char	str2[] = "cou";
	char	*str3;

	printf("/////////////// FT_STRCAT ///////////////\n");
	printf("str1 = '%s'\nstr2 = '%s'\n", str1,str2);
	str3 = (char *)malloc(sizeof(char) * 15);
	str3 = ft_strcat(str1, str2);
	printf("ft_strcat() = '%s'\n\n\n", str3);

	printf("/////////////// FT_PUTS ///////////////\n");
	ft_puts("aaa");
	ft_puts("Bien le bonjour");
	ft_puts(NULL);
	ft_puts("\n");

	char	*strset = strdup("Smash it");

	printf("/////////////// FT_MEMSET ///////////////\n");
	printf("strset = '%s'\n", strset);
	ft_memset(strset, 'C', 3);
	printf("ft_memset(strset, 'C', 3) = '%s'\n\n\n", strset);
	free(strset);

	char	*src_cpy = strdup("The GOAT");
	char	*dest_cpy = strdup("Mango");

	printf("/////////////// FT_MEMCPY ///////////////\n");
	printf("src_cpy = '%s'\ndest_cpy = '%s'\n", src_cpy, dest_cpy);
	ft_memcpy(dest_cpy, src_cpy, 3);
	printf("ft_memcpy(src_cpy, dest_cpy, 3) = '%s'\n\n\n", dest_cpy);

	char *dup = ft_strdup("Champagne");

	printf("/////////////// FT_STRDUP ///////////////\n");
	printf("dup = '%s'\n", dup);
	free(dup);
	printf("dup has been freed\n\n\n");

	return (0);
}
