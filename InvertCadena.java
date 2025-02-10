import java.util.Scanner;

public class InvertCadena {
	static Scanner sc = new Scanner(System.in);
	
	public static void main(String[] args) {
		System.out.println(" INGRESE UNA FRASE PARA PODER INVERTIR: ");
        String cadena = sc.nextLine();
        String invertida = "";
        for (int i = cadena.length() - 1; i >= 0; i--) {
            invertida += cadena.charAt(i);
        }
        System.out.println(invertida);
    }

}
