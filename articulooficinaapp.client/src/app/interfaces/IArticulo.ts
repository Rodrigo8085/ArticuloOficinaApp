export interface IArticulo {
    idArticulos: number;
    codigo: string;
    descripcion?: string;
    precio: number;
    imagen?: string;
    stock: number;
}