namespace MicroRabbit.MVC.Services
{
    using MicroRabbit.MVC.Models.DTO;
    using System.Threading.Tasks;

    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}